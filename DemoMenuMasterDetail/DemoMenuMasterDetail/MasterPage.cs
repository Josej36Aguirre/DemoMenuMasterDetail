using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DemoMenuMasterDetail
{
	public class MasterPage : ContentPage
	{
        public ListView ListView { get { return listView; } }
		public MasterPage ()
		{
			Content = new StackLayout {
				Children = {
					new Label { Text = "Welcome to Xamarin.Forms!" }
				}
			};
		}
	}
}