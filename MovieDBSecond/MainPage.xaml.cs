using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Acr.UserDialogs;
using MovieDBSecond.Models;
using MovieDBSecond.Network;
using MovieDBSecond.ViewModels;
using Refit;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MovieDBSecond
{
   
    public partial class MainPage : ContentPage
    {

        //public IList<Result> datas { get; set; }

        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = new ViewModels.MainPageViewModel();

        }

        //protected async override void OnAppearing()
        //{
        //    base.OnAppearing();

            //LoadData();
            //await CallApi();
        //}

        //async void LoadData()
        //{
        //    datas = new List<MovieModel>();

        //    BaseResponseModel movieData = await _network.GetMovieDataAsync(GenerateRequestUri(Constants.MovieDBEndpoint));
        //    datas = movieData.movies;
        //    BindingContext = this;
        //}

        //private string GenerateRequestUri(string endpoint)
        //{
        //    string requestUri = endpoint;
        //    requestUri += $"?api_key={Constants.MovieDBAPIKey}";
        //    return requestUri;
        //}

        //async void lvSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    if (e.SelectedItem == null)
        //    {
        //        DisplayAlert("ItemSelected", "Null1", "OK");
        //    }
        //    else
        //    {
        //        var secondPage = new MovieDetail();
        //        secondPage.BindingContext = e.SelectedItem as MovieModel;
        //        await Navigation.PushAsync(secondPage);
        //    }
        //}

        //async Task CallApi()
        //{
        //var apiResponse = RestService.For<MovieAPI>("https://api.themoviedb.org/3");
        //var movies = await apiResponse.GetNowPlaying(Constants.MovieDBAPIKey);
        //datas = movies.Results;
        //Debug.WriteLine("bayu123");
        //Debug.WriteLine(movies);
        //Debug.WriteLine("bayu456");
        //Debug.WriteLine(datas[0].Overview);
        //Debug.WriteLine(datas[1].Overview);

        //var apiResponse = MovieDBSecond.Network.NetworkService
        //}
    }
}
