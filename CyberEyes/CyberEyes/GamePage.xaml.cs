﻿using System;
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
		}

		public GamePage(Config config) : this()
		{
			this.config = config;
			var appData = (ScavengerHuntManager)BindingContext;

			// master list
			var itemList = new List<string>();
			var indoorList = new List<string> { "apple", "helmet", "lego", "banana" };
			var colorList = new List<string> { "black", "blue", "red", "pink" };
			var expressionList = new List<string> { "anger", "smile", "confused", "sad" };
			var outdoorList = new List<string> { "tree", "car", "bicycle", "lake" };


			if (this.config.UseIndoors)
			{
				itemList.AddRange(indoorList);
			}
			if (this.config.UseColors)
			{
				itemList.AddRange(colorList);
			}
			if (this.config.UserFacialExperssions)
			{
				itemList.AddRange(expressionList);
			}
			if (this.config.UseOutDoors)
			{
				itemList.AddRange(outdoorList);
			}


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

			// ensure everything has a filename too
			for (int i = 0; i < appData.ItemList.Items.Count; i++)
			{
				appData.ItemList.Items[i].PhotoFilename = $"image_{i}.jpg";
			}

			// ListView.ItemsSource = ItemsToCollect;
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
