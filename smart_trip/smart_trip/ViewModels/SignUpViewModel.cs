using smart_trip.Models;
using smart_trip.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace smart_trip.ViewModels
{
    public class SignUpViewModel : BaseViewModel
    {
        public Command SignUpCommand { get; }

        public string SelectedManufacturer { get; set; }
        public int SelectedManufacturerId { get; set; }
        public ObservableCollection<CarManufacturer> CarManufacturerList { get; set; }
        public SignUpViewModel()
        {
            SignUpCommand = new Command(OnSignUpClicked);
            PopulateCarManufacturers();
        }

        private void PopulateCarManufacturers()
        {
            //call web api to get car manufacturers
            CarManufacturerList = new ObservableCollection<CarManufacturer>();
        }

        private async void OnSignUpClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(AboutPage)}");
        }
    }
}
