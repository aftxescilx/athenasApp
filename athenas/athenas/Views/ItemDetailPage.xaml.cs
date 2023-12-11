using athenas.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace athenas.Views
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