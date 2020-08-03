using System;
using System.Collections.Generic;
using MovieDBSecond.ViewModels;
using Xamarin.Forms;

namespace MovieDBSecond.Views
{
    public partial class LocalDataPage : ContentPage
    {
        public LocalDataPage()
        {
            InitializeComponent();
            var vm = new LocalDataPageViewModel(Navigation, this);
            BindingContext = vm;

            input_data.Completed += (object sender, EventArgs e) =>
            {
                vm.Button_Save.Execute(null);
            };
        }
    }
}
