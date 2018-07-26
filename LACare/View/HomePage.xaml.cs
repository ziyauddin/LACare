using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LACare
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
        HomeViewModel viewmodel = new HomeViewModel();
        public HomePage ()
		{
			InitializeComponent ();
		}
    }
}