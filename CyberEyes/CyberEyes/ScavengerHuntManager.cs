using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Xml.Serialization;
using System.Reflection;
using Xamarin.Forms;

namespace CyberEyes
{
	public class ScavengerHuntManager : ViewModelBase
	{
		const string FILENAME = "file.xml";

		FileHelper fileHelper = new FileHelper(); // handles FileIO per platform

		ScavengerHuntList itemList = new ScavengerHuntList();

		public ScavengerHuntList ItemList
		{
			get { return itemList; }
			set { SetProperty(ref itemList, value); }
		}

		public ScavengerHuntManager()
		{

		}

		public void LoadContents()
		{
			this.itemList = new ScavengerHuntList();

			// gather XML from local storage
			if (fileHelper.Exists(FILENAME))
			{
				string contents = fileHelper.ReadText(FILENAME);

				// Deserialize
				TextReader tr = new StringReader(contents);
				XmlSerializer xml = new XmlSerializer(typeof(ScavengerHuntList));

				this.itemList = xml.Deserialize(tr) as ScavengerHuntList;

				for (int i = 0; i < this.itemList.Items.Count; i++)
				{

					string stringContents = this.itemList.Items[i].Base64StringContents;

					if (!String.IsNullOrEmpty(stringContents))
					{
						var bytes = Convert.FromBase64String(stringContents);

						this.itemList.Items[i].Photo.Source = ImageSource.FromStream(() =>
						{
							Stream stream = new MemoryStream(bytes);
							return stream;
						});
					}
				}
			}
		}

		public void SaveContents()
		{
			// Serialize
			TextWriter tw = new StringWriter();
			XmlSerializer xml = new XmlSerializer(typeof(ScavengerHuntList));
			xml.Serialize(tw, itemList);
			string contents = tw.ToString();

			fileHelper.WriteText(FILENAME, contents);
		}
	}
}
