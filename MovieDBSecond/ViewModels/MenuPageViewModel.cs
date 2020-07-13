using System;
using System.Threading.Tasks;
using System.Windows.Input;
using MovieDBSecond.Views;
using Xamarin.Forms;

namespace MovieDBSecond.ViewModels
{
    public class MenuPageViewModel
    {
        private INavigation navigation;
        private MenuPage menuPage;
        public ICommand MovieTappedCommand { get; set; }

        public MenuPageViewModel(INavigation navigation, MenuPage menuPage)
        {
            this.navigation = navigation;
            this.menuPage = menuPage;

            MovieTappedCommand = new Command(async()=> await GoToMoviesPage());
        }

        private async Task GoToMoviesPage()
        {
            var nextPage = new MainPage();
            await navigation.PushAsync(nextPage);
        }

    }
}
