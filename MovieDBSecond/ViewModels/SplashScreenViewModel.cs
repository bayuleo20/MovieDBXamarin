using System;
using System.Diagnostics;
using System.Threading.Tasks;
using MovieDBSecond.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MovieDBSecond.ViewModels
{
    public class SplashScreenViewModel : BaseViewModel
    {
        private SplashScreen _splashScreen;
        public INavigation navigation { get; set; }
        private Boolean isLogin;

        public SplashScreenViewModel(INavigation navigation, SplashScreen splashScreen)
        {
            this.navigation = navigation;
            _splashScreen = splashScreen;
            GetPreferenceData();
        }

        private void GetPreferenceData()
        {
            isLogin = Preferences.Get("isLogin", false);
            GotoNextPageAsync();
        }

        private void GotoNextPageAsync()
        {
            if (isLogin)
            {
                GotoMenuPage();
            }

            else
            {
                GotoLoginPage();
            }
        }

        private async Task GotoLoginPage()
        {
            var nextPage = new LoginPage();
            await Task.Delay(2000);
            await navigation.PushAsync(nextPage);
            navigation.RemovePage(_splashScreen);
        }

        private async Task GotoMenuPage()
        {
            var nextPage = new MenuPage();
            await Task.Delay(2000);
            await navigation.PushAsync(nextPage);
            navigation.RemovePage(_splashScreen);
        }
    }
}
