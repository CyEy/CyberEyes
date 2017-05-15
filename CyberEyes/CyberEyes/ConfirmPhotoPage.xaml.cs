using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CyberEyes
{
	public partial class ConfirmPhotoPage : ContentPage
	{
		public ConfirmPhotoPage()
		{
			InitializeComponent();
		}

		void Handle_KeepClicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new GamePage(), true);
		}

		void Handle_RetakeClicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new TakePhotoPage(), true);
		}
	}
}
