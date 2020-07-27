using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using MovieDBSecond.Views;
using Xamarin.Forms;

namespace MovieDBSecond.ViewModels
{
    public class LoginPageViewModel : INotifyPropertyChanged
    {
        private INavigation navigation;
        private LoginPage loginPage;
        public event PropertyChangedEventHandler PropertyChanged;
        public Action DisplayInvalidLoginPrompt;
        public ICommand Button_Login { protected set; get; }

        public LoginPageViewModel(INavigation navigation, LoginPage loginPage)
        {
            this.navigation = navigation;
            this.loginPage = loginPage;

            Button_Login = new Command(OnSubmit);
        }

        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }

        private void OnSubmit(object obj)
        {
            if (email == "bayuleo@gmail.com" && password == "123456")
            {
                OpenNextPage();
            }
            else
            {
                DisplayInvalidLoginPrompt();
            }
        }

        private async Task OpenNextPage()
        {
            var nextPage = new MenuPage();
            await Task.Delay(2000);
            await navigation.PushAsync(nextPage);
            navigation.RemovePage(loginPage);
        }
    }
}
