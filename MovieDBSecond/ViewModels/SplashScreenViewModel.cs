using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MovieDBSecond.ViewModels
{
    public class SplashScreenViewModel : BaseViewModel
    {
        private SplashScreen _splashScreen;

        public INavigation navigation { get; set; }

        public SplashScreenViewModel(INavigation navigation, SplashScreen splashScreen)
        {
            this.navigation = navigation;
            _splashScreen = splashScreen;
            GotoNextPageAsync();
        }

        private async Task GotoNextPageAsync()
        {
            var nextPage = new MainPage();
            await Task.Delay(5000);
            await navigation.PushAsync(nextPage);
            navigation.RemovePage(_splashScreen);
        }
    }
}
