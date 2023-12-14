using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace athenas.Views
{
    public partial class LibraryPage : ContentPage
    {
        public LibraryPage()
        {
            InitializeComponent();
        }

        private async void OnImageTapped(object sender, EventArgs e)
        {
            // Aquí realizas la navegación a StoryPage.xaml
            await Navigation.PushAsync(new StoryPage());
        }
    }
}