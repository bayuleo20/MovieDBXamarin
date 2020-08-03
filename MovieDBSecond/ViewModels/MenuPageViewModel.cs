using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using MovieDBSecond.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MovieDBSecond.ViewModels
{
    public class MenuPageViewModel
    {
        private INavigation navigation;
        private MenuPage menuPage;
        public ICommand MovieTappedCommand { get; set; }
        public ICommand LogoutTappedCommand { get; set; }
        public ICommand LocalStorageTappedCommand { get; set; }

        public MenuPageViewModel(INavigation navigation, MenuPage menuPage)
        {
            this.navigation = navigation;
            this.menuPage = menuPage;

            MovieTappedCommand = new Command(async()=> await GoToMoviesPage());
            LocalStorageTappedCommand = new Command(async () => await LocalStoragePage());
            LogoutTappedCommand = new Command(async () => await Logout());
            
        }

        private async Task GoToMoviesPage()
        {
            var nextPage = new MainPage();
            await navigation.PushAsync(nextPage);
        }

        private async Task LocalStoragePage()
        {
            var nextPage = new LocalDataPage();
            await navigation.PushAsync(nextPage);
        }

        private async Task Logout()
        {
            Preferences.Clear();

            var nextPage = new LoginPage();
            await Task.Delay(2000);
            await navigation.PushAsync(nextPage);
            navigation.RemovePage(menuPage);
        }

    }
}
