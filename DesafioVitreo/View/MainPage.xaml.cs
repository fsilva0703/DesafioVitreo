using DesafioVitreo.ViewModel;
using Xamarin.Forms;

namespace DesafioVitreo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }

    }
}
