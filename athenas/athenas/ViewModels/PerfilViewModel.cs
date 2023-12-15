using athenas.Views;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace athenas.ViewModels
{
    public class PerfilViewModel : BaseViewModel
    {
        public PerfilViewModel()
        {
            Title = "Perfil";
            NavigateToDonacionPageCommand = new Command(OnNavigateToDonacionPage);

        }
        private async void OnNavigateToDonacionPage()
        {
            await Shell.Current.Navigation.PushAsync(new DonacionesPage());
        }

        public ICommand NavigateToDonacionPageCommand { get; }
    }

}
