using System;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Foundation;
using CoreFoundation;
using UIKit;
using ImageIO;

[assembly: Dependency(typeof(CyberEyes.iOS.FileHelper))]

namespace CyberEyes.iOS
{
	public class FileHelper : IFileHelper
	{

		public bool Exists(string filename)
		{
			string filepath = GetFilePath(filename);
			return File.Exists(filepath);
		}

		public void WriteText(string filename, string text)
		{
			string filepath = GetFilePath(filename);
			File.WriteAllText(filepath, text);
		}

		public string ReadText(string filename)
		{
			string filepath = GetFilePath(filename);
			return File.ReadAllText(filepath);
		}

		public void WriteImage(string filename, Image image)
		{
			/*
			string filepath = GetFilePath(filename);
			var documentsDirectory = Environment.GetFolderPath
						 (Environment.SpecialFolder.Personal);
			string jpgFilename = System.IO.Path.Combine(documentsDirectory, "Photo.jpg"); // hardcoded filename, overwritten each time

			File.WriteAllText(filepath, text);

			MemoryStream ms = new MemoryStream();
			image.Source.
			File.WriteAllBytes(filename, );
			*/
			/*
			var imgSrc = image.Source;
			var renderer = new StreamImagesourceHandler();
			var photo = renderer.LoadImageAsync(imgSrc);
			var documentsDirectory = Environment.GetFolderPath
				(Environment.SpecialFolder.Personal);
			string jpgFilename = System.IO.Path.Combine(
			documentsDirectory, filename);
			NSData imgData = photo.AsJPEG();

			NSError err = null;
			if (imgData.Save(jpgFilename, false, out err))
			{
				Console.WriteLine("saved as " + jpgFilename);
			}
			else
			{
				Console.WriteLine("NOT saved as " + jpgFilename +
		" because" + err.LocalizedDescription);
			}
*/

		}
		/*
		public Image ReadImage(string filename)
		{
			string filepath = GetFilePath(filename);
			// return File.ReadAllText(filepath);
		}
*/
		public IEnumerable<string> GetFiles()
		{
			return Directory.GetFiles(GetDocsPath());
		}

		public void Delete(string filename)
		{
			File.Delete(GetFilePath(filename));
		}

		// Private methods.
		string GetFilePath(string filename)
		{
			return Path.Combine(GetDocsPath(), filename);
		}

		string GetDocsPath()
		{
			return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
		}
	}
}
