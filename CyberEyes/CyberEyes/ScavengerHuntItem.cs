using System;
using System.Windows.Input;
using System.Xml.Serialization;
using Xamarin.Forms;

namespace CyberEyes
{
	public class ScavengerHuntItem : ViewModelBase
	{
		// FileHelper fileHelper = new FileHelper(); // handles FileIO per platform

		private string title;
		private string description;
		private Image takePhotoIcon;
		private Image photo;
		private string photoFilename;
		private string base64StringContents;
		private int points;
		private int pointsMax;
		private string otherItem1;
		private string otherItem2;
		private int otherItem1Match;
		private int otherItem2Match;




		public string Title { get { return this.title; } set { SetProperty(ref this.title, value); } }
		public string Description { get { return this.description; } set { SetProperty(ref this.description, value); } }

		[XmlIgnore]
		public Image TakePhotoIcon { get { return this.takePhotoIcon; } set { SetProperty(ref this.takePhotoIcon, value); } }

		[XmlIgnore]
		public Image Photo { get { return this.photo; } set { SetProperty(ref this.photo, value); } }

		public string PhotoFilename
		{
			get
			{
				return this.photoFilename;
			}
			set
			{
				SetProperty(ref this.photoFilename, value);
			}
		}

		public string Base64StringContents
		{
			get
			{
				return this.base64StringContents;
			}
			set
			{
				SetProperty(ref this.base64StringContents, value);
			}
		}

		public int Points { get { return this.points; } set { SetProperty(ref this.points, value); } }
		public int PointsMax { get { return this.pointsMax; } set { SetProperty(ref this.pointsMax, value); } }


		public string OtherItem1 { get { return this.otherItem1; } set { SetProperty(ref this.otherItem1, value); } }
		public string OtherItem2 { get { return this.otherItem2; } set { SetProperty(ref this.otherItem2, value); } }

		public int OtherItem1Match { get { return this.otherItem1Match; } set { SetProperty(ref this.otherItem1Match, value); } }
		public int OtherItem2Match { get { return this.otherItem2Match; } set { SetProperty(ref this.otherItem2Match, value); } }


		public ScavengerHuntItem()
		{
			this.Title = string.Empty;
			this.Description = string.Empty;
			this.TakePhotoIcon = new Image();
			this.TakePhotoIcon.Source = ImageSource.FromResource("CyberEyes.Images.camera_icon.png");
			this.Photo = new Image();
			this.Photo.Source = ImageSource.FromResource("CyberEyes.Images.blank_photo_icon.png");
			this.Points = 0;
			this.PointsMax = 100;
           	this.OtherItem1 = "";
			this.OtherItem2 = "";
			this.OtherItem1Match = 0;
			this.OtherItem1Match = 0;
		}
	}
}
