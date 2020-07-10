using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MovieDBSecond.ViewModels
{
    public class SplashScreenViewModel
    {
        private INavigation navigation;

        public SplashScreenViewModel()
        {
            Debug.WriteLine("bayu123");
            GotoNextPageAsync();
        }

        public SplashScreenViewModel(INavigation navigation)
        {
            this.navigation = navigation;
        }

        private async Task GotoNextPageAsync()
        {
            var nextPage = new MainPage();
            await Task.Delay(5000);
            await navigation.PushAsync(nextPage);
        }
    }
}
