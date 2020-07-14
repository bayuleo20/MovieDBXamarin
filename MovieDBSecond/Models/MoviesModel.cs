using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MovieDBSecond.Models
{
    public class Result
    {
        public double Popularity { get; set; }
        public int VoteCount { get; set; }
        public bool Video { get; set; }

        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }

        public int Id { get; set; }
        public bool Adult { get; set; }

        [JsonProperty("backdrop_path")]
        public string BackdropPath { get; set; }

        public string OriginalLanguage { get; set; }
        public string OriginalTitle { get; set; }
        public IList<int> GenreIds { get; set; }
        public string Title { get; set; }
        public double VoteAverage { get; set; }
        public string Overview { get; set; }
        public string ReleaseDate { get; set; }

        public string Poster => $"https://image.tmdb.org/t/p/w500{PosterPath}";
        public string Backdrop => $"https://image.tmdb.org/t/p/w500{BackdropPath}";
    }

    public class Dates
    {
        public string Maximum { get; set; }
        public string Minimum { get; set; }
    }

    public class MoviesModel
    {
        public IList<Result> Results { get; set; }
        public int Page { get; set; }
        public int TotalResults { get; set; }
        public Dates Dates { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
    }
}
