﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoMenuMasterDetail
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterPage : ContentPage
	{
       // internal readonly object ListView;

            public ListView ListView { get { return listView; } }

        public MasterPage ()
		{
			InitializeComponent ();
		}
	}
}