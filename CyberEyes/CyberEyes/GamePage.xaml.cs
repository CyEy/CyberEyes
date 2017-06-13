using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CyberEyes
{
	public partial class GamePage : ContentPage
	{
		Config config;

		public GamePage()
		{
			InitializeComponent();
			this.Appearing += Handle_Appearing;
		}

		public GamePage(Config config) : this()
		{
			this.config = config;
			var appData = (ScavengerHuntManager)BindingContext;

			UpdateStats();

			Device.StartTimer(System.TimeSpan.FromSeconds(1), OnTimerTick);
		}

		bool OnTimerTick()
		{
			var appData = (ScavengerHuntManager)BindingContext;

			appData.TimeLeftInSeconds--;

			if (appData.TimeLeftInSeconds < 0)
			{
				// go to end
				Navigation.PushAsync(new EndScreenPage());
				return false;
			}
			else
			{
				// otherwise, update relevant labels
				TimeSpan t = TimeSpan.FromSeconds(appData.TimeLeftInSeconds);
				timeLeftLabel.Text = $"Time Left: {t.Minutes:D2}:{t.Seconds:D2}";
			}

			return true;
		}

		void Handle_Appearing(object sender, System.EventArgs e)
		{
			UpdateStats();
		}

		void UpdateStats()
		{
			var appData = (ScavengerHuntManager)BindingContext;

			pointsLabel.Text = $"Points: {appData.TotalPoints}/{appData.TotalPointsMax}";
			progressLabel.Text = $"Progress: {appData.ItemsFilled}/{appData.TotalItems}";
		}

		void Handle_TakePhotoTapped(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new TakePhotoPage(), true);
		}

		void Handle_SubmitClicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new EndScreenPage(), true);
		}

		void Handle_ItemDetailsClicked(object sender, System.EventArgs e)
		{
			if (ListView.SelectedItem != null)
			{
				var selectedItem = ListView.SelectedItem as ScavengerHuntItem;
				Navigation.PushModalAsync(new ScoreModalPage(selectedItem), true);
			}
		}

		void Handle_TakePhotoClicked(object sender, System.EventArgs e)
		{
			if (ListView.SelectedItem != null)
			{
				var selectedItem = ListView.SelectedItem as ScavengerHuntItem;
				Navigation.PushModalAsync(new TakePhotoPage(selectedItem), true);
			}
		}
	}
}
