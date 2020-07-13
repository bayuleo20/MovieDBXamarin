using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MovieDBSecond.Views
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
            BindingContext = new ViewModels.MenuPageViewModel(Navigation, this);
        }
    }
}
