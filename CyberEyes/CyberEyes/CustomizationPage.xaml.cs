using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CyberEyes
{
	public partial class CustomizationPage : ContentPage
	{
		App app = Application.Current as App;
		public const int Max_items = 10;

		public CustomizationPage()
		{
			InitializeComponent();
			app.config.UseIndoors = true;
			app.config.UseColors = true;
			app.config.UserFacialExperssions = true;
			app.config.Difficulty = DifficultyLevel.Easy;
		}

		void Handle_StartClicked(object sender, System.EventArgs e)
		{
			// remove any previously defined items
			app.AppData.ItemList.Items.Clear();


			// select items for the search, based on selection
			// master list
			var itemList = new List<string>();
			var indoorList = new List<string> { "apple", "helmet", "lego", "banana" };
			var colorList = new List<string> { "green", "blue", "red", "pink" };
			var expressionList = new List<string> { "anger", "smile", "confused", "sad" };
			var outdoorList = new List<string> { "tree", "car", "bicycle", "lake" };


			if (app.config.UseIndoors)
			{
				itemList.AddRange(indoorList);
			}
			if (app.config.UseColors)
			{
				itemList.AddRange(colorList);
			}
			if (app.config.UserFacialExperssions)
			{
				itemList.AddRange(expressionList);
			}
			if (app.config.UseOutDoors)
			{
				itemList.AddRange(outdoorList);
			}

			for (int i = 0; i < Max_items; i++)
			{
				// pick a random prompt
				Random random = new Random(DateTime.Now.Millisecond);
				int itemIndex = random.Next(0, itemList.Count);
				string itemString = itemList[itemIndex];
				itemList.Remove(itemString);

				// create an item
				ScavengerHuntItem newItem = new ScavengerHuntItem();
				newItem.Title = itemString;
				newItem.Description = $"Find a {itemString}";

				// add it to the list
				app.AppData.ItemList.Items.Add(newItem);
			}

			// begin the game
			Navigation.PushAsync(new GamePage(app.config), true);
		}

		void Handle_EasyTapped(object sender, System.EventArgs e)
		{
			easyFrame.BackgroundColor = Color.Accent;
			var label = easyFrame.Content as Label;
			label.Text = "● Easy";

			mediumFrame.BackgroundColor = Color.Default;
			label = mediumFrame.Content as Label;
			label.Text = "○ Medium";

			hardFrame.BackgroundColor = Color.Default;
			label = hardFrame.Content as Label;
			label.Text = "○ Hard";

			app.config.Difficulty = DifficultyLevel.Easy;
		}

		void Handle_MediumTapped(object sender, System.EventArgs e)
		{
			easyFrame.BackgroundColor = Color.Default;
			var label = easyFrame.Content as Label;
			label.Text = "○ Easy";

			mediumFrame.BackgroundColor = Color.Accent;
			label = mediumFrame.Content as Label;
			label.Text = "● Medium";

			hardFrame.BackgroundColor = Color.Default;
			label = hardFrame.Content as Label;
			label.Text = "○ Hard";

			app.config.Difficulty = DifficultyLevel.Medium;
		}

		void Handle_HardTapped(object sender, System.EventArgs e)
		{
			easyFrame.BackgroundColor = Color.Default;
			var label = easyFrame.Content as Label;
			label.Text = "○ Easy";

			mediumFrame.BackgroundColor = Color.Default;
			label = mediumFrame.Content as Label;
			label.Text = "○ Medium";

			hardFrame.BackgroundColor = Color.Accent;
			label = hardFrame.Content as Label;
			label.Text = "● Hard";

			app.config.Difficulty = DifficultyLevel.Hard;
		}

		void Handle_Toggled(object sender, Xamarin.Forms.ToggledEventArgs e)
		{
			var switched = sender as Switch;

			switch (switched.StyleId)
			{
				case "indoorsSwitch":
					app.config.UseIndoors = switched.IsToggled;
					break;
				case "outdoorsSwitch":
					app.config.UseOutDoors = switched.IsToggled;
					break;
				case "facialExpressionsSwitch":
					app.config.UserFacialExperssions = switched.IsToggled;
					break;
				case "colorsSwitch":
					app.config.UseColors = switched.IsToggled;
					break;
			}
		}
	}
}
