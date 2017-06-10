using Xamarin.Forms;

namespace CyberEyes
{
	public partial class App : Application
	{
		public Config config = new Config();
		public ScavengerHuntManager AppData { private set; get; }

		public App()
		{
			InitializeComponent();
			AppData = new ScavengerHuntManager();
			AppData.LoadContents();

			// Set settings

			MainPage = new NavigationPage(new MainScreenPage());
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
			// Save settings
			AppData.SaveContents();
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
