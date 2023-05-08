using smart_trip.ViewModels;
using smart_trip.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace smart_trip
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//SignUpPage");
        }
    }
}
