using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MovieDBSecond.Service
{
    public interface IApiManager
    {
        Task<HttpResponseMessage> GetNowPlaying(string api_key);
    }
}
