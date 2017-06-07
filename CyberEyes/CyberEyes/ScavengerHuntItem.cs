using System;
using Xamarin.Forms;

namespace CyberEyes
{
	public class ScavengerHuntItem
	{
		public string Title { get; set; }
		public string Description { get; set; }
		public Image TakePhotoIcon { get; }
		public Image Photo { get; set; }
		public int Points { get; set; }
		public int PointsMax { get; set; }

		public ScavengerHuntItem()
		{
			this.Title = string.Empty;
			this.Description = string.Empty;
			this.TakePhotoIcon = new Image();
            this.TakePhotoIcon.Source = ImageSource.FromResource("CyberEyes.Images.camera_icon.png");
			this.Photo = new Image();
            this.Photo.Source = ImageSource.FromResource("CyberEyes.Images.blank_photo_icon.png");
			this.Points = 0;
			this.PointsMax = 1;
		}
	}
}
