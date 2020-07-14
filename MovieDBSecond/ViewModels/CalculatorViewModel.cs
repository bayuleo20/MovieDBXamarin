using System;
using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Forms;

namespace MovieDBSecond.ViewModels
{
    public class CalculatorViewModel : BaseViewModel
    {

        private int number1 { get; set; }
        private int number2 { get; set; }
        private int numberResult { get; set; }
        public Command ButtonCalculate { get; }
        public CalculatorViewModel()
        {
            ButtonCalculate = new Command(CalculateData);
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

        private void CalculateData()
        {
            numberResult = number1 + number2;
            Debug.WriteLine("Bayu result : ");
            Debug.WriteLine(numberResult);

            OnPropertyChanged(nameof(ResultCalculator));
        }
    }
}
