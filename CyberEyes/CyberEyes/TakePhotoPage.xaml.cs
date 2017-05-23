using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CyberEyes
{
	public partial class TakePhotoPage : ContentPage
	{
		public TakePhotoPage()
		{
			InitializeComponent();

			CameraDisplay.Source = ImageSource.FromResource("CyberEyes.Images.blank_camera.png");
		}

		void Handle_TakeClicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new ConfirmPhotoPage(), true);
		}
	}
}
