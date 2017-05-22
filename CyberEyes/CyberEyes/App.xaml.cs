using Xamarin.Forms;

namespace CyberEyes
{
	public partial class App : Application
	{
		public Config config = new Config();

		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new MainScreenPage());
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
