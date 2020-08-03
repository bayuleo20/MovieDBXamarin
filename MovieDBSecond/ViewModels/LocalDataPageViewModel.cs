using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Input;
using MovieDBSecond.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MovieDBSecond.ViewModels
{
    public class LocalDataPageViewModel : INotifyPropertyChanged
    {
        private INavigation navigation;
        private LocalDataPage localDataPage;
        public event PropertyChangedEventHandler PropertyChanged;
        public string DataLocalLogin { set; get; }
        public string DataLocalSave { set; get; }
        public ICommand Button_Save { protected set; get; }

        public LocalDataPageViewModel(INavigation navigation, LocalDataPage localDataPage)
        {
            this.navigation = navigation;
            this.localDataPage = localDataPage;
            Button_Save = new Command(OnSave);

            getLocalData();;
        }

        private string inputData;
        public string InputData
        {
            get { return inputData; }
            set
            {
                inputData = value;
                PropertyChanged(this, new PropertyChangedEventArgs("InputData"));
            }
        }

        private void OnSave(object obj)
        {
            Debug.WriteLine("Test999");
            Debug.WriteLine(inputData);
            Preferences.Set("saveData", inputData);

        }

        private void getLocalData()
        {
            DataLocalLogin = Preferences.Get("myData", "Empty");
            DataLocalSave = Preferences.Get("saveData", "Empty");
        }

        //private string _dataLocal;
        //public string dataLocal
        //{
        //    get { return _dataLocal; }
        //    set
        //    {
        //        _dataLocal = value;
        //        PropertyChanged(this, new PropertyChangedEventArgs("DataLocal"));
        //    }
        //}
    }
}
