using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CyberEyes
{
	public partial class CustomizationPage : ContentPage
	{
		public CustomizationPage()
		{
			InitializeComponent();
		}

		void Handle_StartClicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new GamePage(), true);
		}
	}
}
