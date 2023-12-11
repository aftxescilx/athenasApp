using athenas.Views;
using System.Windows.Input;
using Xamarin.Forms;

namespace athenas.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command HomeCommand { get; }

        public LoginViewModel()
        {
            HomeCommand = new Command(OnHomeClicked);
            NavigateToRegisterPageCommand = new Command(OnNavigateToRegisterPage);

        }

        private async void OnHomeClicked(object obj)
        {
            // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
            await Shell.Current.GoToAsync($"//{nameof(HomePage)}");

        }

        private async void OnNavigateToRegisterPage()
        {
            await Shell.Current.Navigation.PushAsync(new RegisterPage());
        }



        public ICommand NavigateToRegisterPageCommand { get; }


    }
}
