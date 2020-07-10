using System;
using System.Collections.Generic;
using MovieDBSecond.ViewModels;
using Xamarin.Forms;

namespace MovieDBSecond
{
    public partial class SplashScreen : ContentPage
    {
        public SplashScreen()
        {
            InitializeComponent();
            BindingContext = new ViewModels.SplashScreenViewModel(Navigation, this);
        }
    }
}
