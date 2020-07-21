using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Forms;

namespace MovieDBSecond.ViewModels
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {

        private int number1 { get; set; }
        private int number2 { get; set; }
        public int numberResult { get; set; }
        public Command ButtonCalculate { get; }
        private BaseViewModel baseViewModel;

        public event PropertyChangedEventHandler PropertyChanged;

        public CalculatorViewModel()
        {
            ButtonCalculate = new Command(CalculateData);
        }

        public CalculatorViewModel(Boolean isTest = false)
        {
            if (!isTest) { baseViewModel = new BaseViewModel(); }
        }

        public int Number1
        {
            get { return number1; }
            set { number1 = value; }
        }

        public int Number2
        {
            get { return number2; }
            set { number2 = value; }
        }

        public string ResultCalculator
        {
            get { return numberResult.ToString(); }
        }

        public void CalculateData()
        {
            numberResult = number1 + number2;
            Debug.WriteLine("Bayu result : ");
            Debug.WriteLine(numberResult);

            OnPropertyChanged(nameof(ResultCalculator));
        }

        protected void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
