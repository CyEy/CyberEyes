using System;
using System.Collections.Generic;
using Plugin.Media;

using Xamarin.Forms;

namespace CyberEyes
{
	public partial class TakePhotoPage : ContentPage
	{
		ScavengerHuntItem item;

		public TakePhotoPage()
		{
			InitializeComponent();
			this.item = new ScavengerHuntItem();
            this.BindingContext = this.item;

			// filler item
			this.item.Photo.Source = ImageSource.FromResource("CyberEyes.Images.blank_camera.png");

			// based on example from here: https://github.com/jamesmontemagno/MediaPlugin
			TakePhoto.Clicked += async(sender, args) =>
			{
				await CrossMedia.Current.Initialize();

				if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
				{

					await DisplayAlert("No Camera", ":( No camera available.", "OK");
					return;
				}

				var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
				{
					Directory = "Sample",
					Name = "test.jpg"
				});

				if (file == null)
					return;

				// await DisplayAlert("File Location", file.Path, "OK");

				this.item.Photo.Source = ImageSource.FromStream(() =>
					{
						var stream = file.GetStream();
						file.Dispose();
						return stream;
					});

				//or:
				//image.Source = ImageSource.FromFile(file.Path);
				//image.Dispose
			};
		}

		public TakePhotoPage(ScavengerHuntItem selectedItem) : this()
		{
			this.item = selectedItem;
		}


		/*
		void Handle_TakeClicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new ConfirmPhotoPage(), true);
		}
*/

		void Handle_ReturnClicked(object sender, System.EventArgs e)
		{
			Navigation.PopAsync();
		}
	}
}
