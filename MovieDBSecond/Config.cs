using System;
using System.Text.RegularExpressions;

namespace MovieDBSecond
{
    public class Config
    {
        public static string ApiUrl = "https://api.themoviedb.org/3";

        public static string ApiHostName
        {
            get
            {
                //var apiHostName = Regex.Replace(ApiUrl, @"^(?:http(?:s)?://)?(?:www(?:[0-9]+)?\.)?", string.Empty, RegexOptions.IgnoreCase)
                //                   .Replace("/", string.Empty);
                //return apiHostName;

                return ApiUrl;
            }
        }
    }
}
