using System;
using System.Collections.ObjectModel;

namespace CyberEyes
{
	public class ScavengerHuntList : ViewModelBase
	{
		ObservableCollection<ScavengerHuntItem> items = new ObservableCollection<ScavengerHuntItem>();

		public ObservableCollection<ScavengerHuntItem> Items
		{
			set { SetProperty(ref items, value); }
			get { return items; }
		}
	}
}
