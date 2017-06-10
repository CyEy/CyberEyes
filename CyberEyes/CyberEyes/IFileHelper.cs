using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace CyberEyes
{
	public interface IFileHelper
	{
		bool Exists(string filename);

		void WriteText(string filename, string text);

		string ReadText(string filename);

		// void WriteImage(string filename, Image image);

		// Image ReadImage(string filename);

		IEnumerable<string> GetFiles();

		void Delete(string filename);
	}
}
