using System;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(CyberEyes.Droid.FileHelper))]

namespace CyberEyes.Droid
{
	public class FileHelper
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

			 ImageSource.FromFile(filename);
		}

		public string ReadText(string filename)
		{
			string filepath = GetFilePath(filename);
			return File.ReadAllText(filepath);
		}

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
