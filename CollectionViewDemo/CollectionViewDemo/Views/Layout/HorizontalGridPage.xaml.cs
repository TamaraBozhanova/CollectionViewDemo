using CollectionViewDemo.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewDemo.Views.Layout
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HorizontalGridPage : ContentPage
	{
		public HorizontalGridPage ()
		{
			InitializeComponent ();
            BindingContext = new MonkeysViewModel();
        }
	}
}