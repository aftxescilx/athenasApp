using athenas.Views;
using System.Windows.Input;
using Xamarin.Forms;

namespace athenas.ViewModels
{
    public class DonacionesViewModel : BaseViewModel
    {
        public Command HomeCommand { get; }

        public DonacionesViewModel()
        {
            Title = "Donaciones";
        }

      
    }
}
