using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
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

        public void CalculatorTappedCommand(object sender, EventArgs e)
        {
            OpenNewPageAsync();
        }

        private async Task OpenNewPageAsync()
        {
            var newPage = new CalculatorPage();
            await Navigation.PushAsync(newPage);
        }

    }
}
