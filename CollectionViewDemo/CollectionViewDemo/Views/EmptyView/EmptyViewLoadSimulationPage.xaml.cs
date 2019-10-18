using CollectionViewDemo.ViewModels;
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
    public partial class EmptyViewLoadSimulationPage : ContentPage
    {
        public EmptyViewLoadSimulationPage()
        {
            InitializeComponent();
            BindingContext = new MonkeysViewModel();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await Task.Delay(2000);
            collectionView.ItemsSource = (BindingContext as MonkeysViewModel).Monkeys;
        }
    }
}