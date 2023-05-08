using smart_trip.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace smart_trip.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}