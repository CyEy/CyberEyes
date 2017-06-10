using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CyberEyes
{
	public partial class GamePage : ContentPage
	{
		public List<ScavengerHuntItem> ItemsToCollect = new List<ScavengerHuntItem>();

		public GamePage()
		{
			InitializeComponent();

			// generate some dummy items to display
			for (int i = 0; i < 10; i++)
			{
				var newItem = new ScavengerHuntItem()
				{
					Title = $"Item Title + {i}",
					Description = $"Item Description + {i}",
					Points = 0,
					PointsMax = 3
				};

				ItemsToCollect.Add(newItem);
			}

			ListView.ItemsSource = ItemsToCollect;
		}

		void Handle_ModalTapped(object sender, System.EventArgs e)
		{
			Navigation.PushModalAsync(new ScoreModalPage(), true);
		}

		void Handle_TakePhotoTapped(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new TakePhotoPage(), true);
		}

		void Handle_SubmitClicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new EndScreenPage(), true);
		}

		void Handle_OpenCameraClicked(object sender, System.EventArgs e)
		{
			Navigation.PushModalAsync(new TakePhotoPage(ItemsToCollect[0]), true);
		}

		void Handle_ScoreModalClicked(object sender, System.EventArgs e)
		{
			Navigation.PushModalAsync(new ScoreModalPage(), true);
		}

		void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			ListView.SelectedItem = null;
		}
	}
}
