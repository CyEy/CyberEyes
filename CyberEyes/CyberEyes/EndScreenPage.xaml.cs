using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CyberEyes
{
	public partial class EndScreenPage : ContentPage
	{
		public EndScreenPage()
		{
			InitializeComponent();
		}

		void Handle_NewGameClicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new MainScreenPage(), true);
		}
	}
}
