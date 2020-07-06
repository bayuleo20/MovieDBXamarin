using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MovieDBSecond
{
    public interface MovieInterface
    {
        Task<HttpResponseMessage> GetPlayingNow(string api_key);
    }
}
