using System;
using System.Net.Http;

namespace MovieDBSecond.ViewModels
{
    public class MovieDetailViewModel
    {
        private BaseViewModel baseViewModel;
        public int Result { get; set; }

        public MovieDetailViewModel()
        {
            baseViewModel = new BaseViewModel();
        }

        public MovieDetailViewModel(Boolean isTest = false)
        {
            if (!isTest) { baseViewModel = new BaseViewModel(); }

        }

        public void Perkalian(int a, int b)
        {
            var result = a * b;
            Result = result;
        }



    }
}
