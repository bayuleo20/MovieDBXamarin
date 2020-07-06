using System;
using Newtonsoft.Json;

namespace MovieDBSecond.Models
{
    public class MovieModel
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("vote_average")]
        public double Rating { get; set; }

        [JsonProperty("release_date")]
        public string Release { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }

        [JsonProperty("poster_path")]
        public string Poster_Path { get; set; }

        [JsonProperty("backdrop_path")]
        public string Backdrop_Path { get; set; }

        public string Image => $"https://image.tmdb.org/t/p/w500{Poster_Path}";
        public string Backdrop => $"https://image.tmdb.org/t/p/w500{Backdrop_Path}";
    }
}
