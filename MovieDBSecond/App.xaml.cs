﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MovieDBSecond
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new MainPage());
            //MainPage = new MainPage();
            MainPage = new NavigationPage(new SplashScreen());

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
