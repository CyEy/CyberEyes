using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CyberEyes
{
	public partial class MainScreenPage : ContentPage
	{
		public MainScreenPage()
		{
			InitializeComponent();
		}

		void Handle_StartClicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new CustomizationPage(), true);
		}

		void Handle_ContinueClicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new GamePage(), true);
		}
	}
}
