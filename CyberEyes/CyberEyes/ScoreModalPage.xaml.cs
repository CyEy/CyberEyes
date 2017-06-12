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

		//public ScoreModalPage()
		//{
		//	InitializeComponent();
		//	////Image img = new Image { };

		//	item = new ScavengerHuntItem();
		//	item.Photo.Source = ImageSource.FromResource("CyberEyes.Images.blank_camera.png");
		//	itemPhoto.Source = ImageSource.FromResource("CyberEyes.Images.blank_camera.png");

		//}

		public ScoreModalPage(ScavengerHuntItem newItem)
		{
			//ScavengerHuntItem item = new ScavengerHuntItem();
			//item.Points = newItem.Points;
			//item.Title = newItem.Title;
			//item.Points = newItem.Points;
			string title = newItem.Title;

			this.item = newItem;

			modalLabel.Text = title;
			itemMatch.Text = String.Format("Match Confidence: {0}", newItem.Points);
			otherItem1.Text = String.Format("{0}: {1}", newItem.OtherItem1, newItem.OtherItem1Match);
			otherItem2.Text = String.Format("{0}: {1}", newItem.OtherItem2, newItem.OtherItem2Match);
		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PopModalAsync(true);
		}
	}
}
