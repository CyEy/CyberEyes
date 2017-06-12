using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CyberEyes
{
	public partial class ConfirmPhotoPage : ContentPage
	{
		App app = Application.Current as App;

		public ConfirmPhotoPage()
		{
			InitializeComponent();

			CameraDisplay.Source = ImageSource.FromResource("CyberEyes.Images.blank_camera.png");
		}

		void Handle_KeepClicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new GamePage(app.config), true);
		}

		void Handle_RetakeClicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new TakePhotoPage(), true);
		}
	}
}
