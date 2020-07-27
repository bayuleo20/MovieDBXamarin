using System;
using System.Collections.Generic;
using MovieDBSecond.ViewModels;
using Xamarin.Forms;

namespace MovieDBSecond.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            var vm = new LoginPageViewModel(Navigation, this);
            BindingContext = vm;
            vm.DisplayInvalidLoginPrompt += () => DisplayAlert("Error", "Invalid Login, try again", "OK");

            input_email.Completed += (object sender, EventArgs e) =>
            {
                input_password.Focus();
            };

            input_password.Completed += (object sender, EventArgs e) =>
            {
                vm.Button_Login.Execute(null);
            };
        }
    }
}
