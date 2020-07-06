using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using MovieDBSecond.Models;
using Refit;

namespace MovieDBSecond
{
    [Headers("Content-Type: application/json")]
    public interface MovieAPI
    {
        [Get("/movie/now_playing")]
        Task<HttpResponseMessage> GetNowPlaying(string api_key);
    }
}
