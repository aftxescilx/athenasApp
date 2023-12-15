using athenas.Views;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace athenas.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Inicio";
            NavigateToLoginPageCommand = new Command(OnNavigateToLoginPage);
            NavigateToRegisterPageCommand = new Command(OnNavigateToRegisterPage);
        }

       
        private async void OnNavigateToLoginPage()
        {
            await Shell.Current.Navigation.PushAsync(new LoginPage());
        }
        private async void OnNavigateToRegisterPage()
        {
            await Shell.Current.Navigation.PushAsync(new RegisterPage());
        }



        public ICommand NavigateToRegisterPageCommand { get; }
        public ICommand NavigateToLoginPageCommand { get; }
    }
}
