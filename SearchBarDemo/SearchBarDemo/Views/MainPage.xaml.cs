using SearchBarDemo.ViewModels;
using Xamarin.Forms;

namespace SearchBarDemo.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModels();
        }
    }
}
