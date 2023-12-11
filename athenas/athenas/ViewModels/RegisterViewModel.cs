using athenas.Views;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace athenas.ViewModels
{
    public class RegisterViewModel : ContentPage
    {
        public Command HomeCommand { get; }

        public RegisterViewModel()
        {
            HomeCommand = new Command(OnHomeClicked);
            NavigateToLoginPageCommand = new Command(OnNavigateToLoginPage);

        }

        private async void OnHomeClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(HomePage)}");

        }

        private async void OnNavigateToLoginPage()
        {
            await Shell.Current.Navigation.PushAsync(new LoginPage());
        }
        public ICommand NavigateToLoginPageCommand { get; }

    }
}