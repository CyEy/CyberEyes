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

			fTime.Text = String.Format("Time Left: {0}", appData.TimeLeftInSeconds);
			fFound.Text = String.Format("Items Found: {0}/{1}", appData.ItemsFilled, appData.TotalItems);
			fPoints.Text = String.Format("Total Points: {0}/{1}", appData.TotalPoints, appData.TotalPointsMax);

		}

		void Handle_NewGameClicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new MainScreenPage(), true);
		}
	}
}
