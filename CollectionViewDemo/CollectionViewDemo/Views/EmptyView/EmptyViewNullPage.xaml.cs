using CollectionViewDemo.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectionViewDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmptyViewNullPage : ContentPage
    {
        public EmptyViewNullPage()
        {
            InitializeComponent();
            BindingContext = new MonkeysViewModel();
        }
    }
}