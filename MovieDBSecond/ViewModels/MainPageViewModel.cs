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

        public MainPageViewModel()
        {
            GetDataCommand = new Command(async()=>await RunSafe(GetData()));
        }

        async Task GetData()
        {
            var moviesResponse = await ApiManager.GetNowPlaying(Constants.MovieDBAPIKey);

            if (moviesResponse.IsSuccessStatusCode)
            {
                var response = await moviesResponse.Content.ReadAsStringAsync();
                var json = await Task.Run(() => JsonConvert.DeserializeObject<MoviesModel>(response));
                Debug.WriteLine("bayu777");
                Debug.WriteLine(response);
                Debug.WriteLine(json.Results[0].Title);
                Debug.WriteLine(json.Results[0].PosterPath);
                Movies = new ObservableCollection<Result>(json.Results);
                Debug.WriteLine("bayu888");
                Debug.WriteLine(Movies);

                pageTitle = "Bayu New";
                OnPropertyChanged("Movies");
                OnPropertyChanged("PageTitle");
            }
            else{
                Debug.WriteLine("bayu777");
                Debug.WriteLine(moviesResponse.StatusCode);
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


    }
}
