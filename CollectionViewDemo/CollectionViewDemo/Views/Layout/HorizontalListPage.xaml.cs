﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionViewDemo.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewDemo.Views.Layout
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HorizontalListPage : ContentPage
	{
		public HorizontalListPage ()
		{
			InitializeComponent ();
            BindingContext = new MonkeysViewModel();
        }
	}
}