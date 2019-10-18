﻿using CollectionViewDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmptyViewTemplatePage : ContentPage
    {
        public EmptyViewTemplatePage()
        {
            InitializeComponent();
            BindingContext = new MonkeysViewModel();
        }
    }
}