using System;
using Refit;

namespace MovieDBSecond.Network
{
    public class NetworkService
    {
        //public static MovieAPI movieAPI;

        
        //public static MovieAPI GetApiService()
        //{
            //var apiResponse = RestService.For<MovieAPI>(Constants.MovieDBEndpoint);
            //var movies = await apiResponse.GetNowPlaying(Constants.MovieDBAPIKey);
            //datas = movies.Results;
            //return apiResponse;


        //}
        //var apiResponse = RestService.For<MovieAPI>("https://api.themoviedb.org/3");
        //var movies = await apiResponse.GetNowPlaying(Constants.MovieDBAPIKey);
        //datas = movies.Results;


        public NetworkService(MovieInterface _movieAPI)
        {

        }


    }
}
