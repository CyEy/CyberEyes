using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using XLabs.Forms.Controls;

namespace CyberEyes
{
	public partial class ScoreModalPage : ContentPage
	{
		ScavengerHuntItem item;
		
		public ScoreModalPage()
		{
			InitializeComponent();
			////Image img = new Image { };

			item = new ScavengerHuntItem();
			item.Photo.Source = ImageSource.FromResource("CyberEyes.Images.blank_camera.png");
			itemPhoto.Source = ImageSource.FromResource("CyberEyes.Images.blank_camera.png");

			//var button = new Button
			//{
			//	Text = "Open popup"
			//};

			//var closePopup = new Button
			//{
			//	Text = "close popup",
			//	BackgroundColor = Color.Red
			//};

			//var popup = new PopupLayout
			//{
			//	Content = new StackLayout
			//	{
			//		VerticalOptions = LayoutOptions.CenterAndExpand,
			//		HorizontalOptions = LayoutOptions.CenterAndExpand,
			//		Children =
			//	{
			//			modalLabel,
			//			itemPhoto,
			//			itemMatch,
			//			otherItems,
			//			otherItem1,
			//			otherItem2,
			//			close
			//	}
			//	}
			//};

			//var label = new Label()
			//{
			//	Text = "item",
			//	HeightRequest = 100,
			//	WidthRequest = 200
			//};
			////modalSL.Children.Add(button);
			////modalSL.Children.Add(popup);

			//button.Clicked += (sender, e) =>
			//			{
			//				button.IsEnabled = false;
			//				popup.ShowPopup(modalSL);

			//			};
			//closePopup.Clicked += (sender, e) =>
			//			{
			//				button.IsEnabled = true;
			//				popup.DismissPopup();
			//			};

		}

		public ScoreModalPage(ScavengerHuntItem newItem) : this ()
		{
			this.item = newItem;
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PopModalAsync(true);
		}
	}
}
