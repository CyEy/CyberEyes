using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CyberEyes
{
	public partial class EndScreenPage : ContentPage
	{
		public EndScreenPage()
		{
			InitializeComponent();
			finalPhoto.Source = ImageSource.FromResource("CyberEyes.Images.finalImage.jpg");

			var appData = (ScavengerHuntManager)BindingContext;

			TimeSpan t = TimeSpan.FromSeconds(appData.TimeLeftInSeconds);
			fTime.Text = String.Format("Time Left: {0:D2}:{1:D2}", t.Minutes, t.Seconds);
			fFound.Text = String.Format("Items Found: {0}/{1}", appData.ItemsFilled, appData.TotalItems);
			fPoints.Text = String.Format("Total Points: {0}/{1}", appData.TotalPoints, appData.TotalPointsMax);

		}

		void Handle_NewGameClicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new MainScreenPage(), true);
		}
	}
}
