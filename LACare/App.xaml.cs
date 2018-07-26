using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace LACare
{
	public partial class App : Application
	{
        public static NavigationPage Navigation = null;
        public App ()
		{
			InitializeComponent();

            Navigation = new NavigationPage(new HomePage());
            Application.Current.MainPage = Navigation;
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
