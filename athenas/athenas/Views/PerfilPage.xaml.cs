using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace athenas.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PerfilPage : ContentPage
	{
		public PerfilPage ()
		{
			InitializeComponent ();
		}
        private async void OnImageTapped(object sender, EventArgs e)
        {
            // Aquí realizas la navegación a StoryPage.xaml
            await Navigation.PushAsync(new DonacionesPage());
        }

        private async void OnAuthorTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PerfilAutoraPage());
        }
    }
}