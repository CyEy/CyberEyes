using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CyberEyes
{
	public partial class GamePage : ContentPage
	{
		Config config;

		// public List<ScavengerHuntItem> ItemsToCollect = new List<ScavengerHuntItem>();

		public GamePage()
		{
			InitializeComponent();
			this.Appearing += Handle_Appearing;
		}

		public GamePage(Config config) : this()
		{
			this.config = config;
			var appData = (ScavengerHuntManager)BindingContext;

			/*
			// generate some dummy items to display (if less than 10 present)
			for (int i = Math.Max(appData.ItemList.Items.Count - 1, 0); i < itemList.Count; i++)
			{
				var newItem = new ScavengerHuntItem()
				{
					Title = itemList[i],
					Description = $"Find: {itemList[i]}",
				};

				appData.ItemList.Items.Add(newItem);
			}

			// filename is deprecated
			// ensure everything has a filename too
			for (int i = 0; i < appData.ItemList.Items.Count; i++)
			{
				appData.ItemList.Items[i].PhotoFilename = $"image_{i}.jpg";
			}
			*/
			// ListView.ItemsSource = ItemsToCollect;

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
		/*
		void Handle_OpenCameraClicked(object sender, System.EventArgs e)
		{
			Navigation.PushModalAsync(new TakePhotoPage(ItemsToCollect[0]), true);
		}

		void Handle_ScoreModalClicked(object sender, System.EventArgs e)
		{
			Navigation.PushModalAsync(new ScoreModalPage(), true);
		}
		*/
		/*
		void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			ListView.SelectedItem = null;
		}
*/
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
