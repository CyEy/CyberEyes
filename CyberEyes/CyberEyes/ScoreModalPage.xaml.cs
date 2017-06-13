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
		}

		public ScoreModalPage(ScavengerHuntItem newItem) : this ()
		{
			this.item = newItem;

			modalLabel.Text = this.item.Title;
			itemPhoto.Source = this.item.Photo.Source;
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
