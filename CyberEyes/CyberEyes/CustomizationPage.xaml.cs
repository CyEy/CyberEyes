using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CyberEyes
{
	public partial class CustomizationPage : ContentPage
	{
		App app = Application.Current as App;

		public CustomizationPage()
		{
			InitializeComponent();
		}

		void Handle_StartClicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new GamePage(), true);
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
