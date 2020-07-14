using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MovieDBSecond.Views
{
    public partial class CalculatorPage : ContentPage
    {

        ViewModels.CalculatorViewModel _viewModel = new ViewModels.CalculatorViewModel(); 
        public CalculatorPage()
        {
            InitializeComponent();
            BindingContext = _viewModel;
        }
    }
}
