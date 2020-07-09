using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using MovieDBSecond.Models;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace MovieDBSecond.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public ObservableCollection<Result> Movies { get; set; }
        public ICommand GetDataCommand { get; set; }
        string pageTitle = "Bayu Movie";
        bool isLoading = false;


        public MainPageViewModel()
        {
            GetDataCommand = new Command(async()=>await RunSafe(GetData()));
        }

        async Task GetData()
        {
            isLoading = true;
            OnPropertyChanged("IsLoading");
            var moviesResponse = await ApiManager.GetNowPlaying();

            if (moviesResponse.IsSuccessStatusCode)
            {
                var response = await moviesResponse.Content.ReadAsStringAsync();
                var json = await Task.Run(() => JsonConvert.DeserializeObject<MoviesModel>(response));
                Movies = new ObservableCollection<Result>(json.Results);
                OnPropertyChanged("Movies");

                //test code for update string page title on UI
                pageTitle = "Bayu New";
                OnPropertyChanged("PageTitle");

                await Application.Current.MainPage.DisplayAlert("Success to get data", "Good", "Ok");
                isLoading = false;
                OnPropertyChanged("IsLoading");
            }
            else{
                await Application.Current.MainPage.DisplayAlert("Unable to get data", "Error", "Ok");
                isLoading = false;
                OnPropertyChanged("IsLoading");
                //await PageDialog.AlertAsync("Unable to get data", "Error", "Ok");
            }
        }

        //async Task GetData()
        //{
        //    var apiResponse = RestService.For<MovieInterface>(Constants.MovieDBEndpoint);
        //    var nowPlaying = await apiResponse.GetPlayingNow(Constants.MovieDBAPIKey);

        //    NowPlaying = new IObservable<Result>(nowPlaying);
        //}

        //string pageTitle = "BayuMovie";

        public String PageTitle
        {
            get { return pageTitle; }
            set { pageTitle = value; }
        }

        public Boolean IsLoading
        {
            get { return isLoading; }
            set { isLoading = value; }
        }



    }
}
