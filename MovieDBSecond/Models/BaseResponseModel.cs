using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MovieDBSecond.Models
{
    public class BaseResponseModel
    {
        [JsonProperty("results")]
        public List<MovieModel> movies { set; get; }
    }
}
