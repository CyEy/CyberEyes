using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CyberEyes
{
	public partial class GamePage : ContentPage
	{
		public GamePage()
		{
			InitializeComponent();
		}

		void Handle_SubmitClicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new EndScreenPage(), true);
		}

		void Handle_OpenCameraClicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new TakePhotoPage(), true);
		}

		void Handle_ScoreModalClicked(object sender, System.EventArgs e)
		{
			Navigation.PushModalAsync(new ScoreModalPage(), true);
		}
	}
}
