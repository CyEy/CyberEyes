using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CyberEyes
{
	public partial class CustomizationPage : ContentPage
	{
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
		}
	}
}
