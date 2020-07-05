using DesafioVitreo.Model;
using DesafioVitreo.ViewModel;
using Xamarin.Forms;

namespace DesafioVitreo.View
{
    public partial class DescriptionPage : ContentPage
    {
        DescriptionPageViewModel viewModel;
        public DescriptionPage(Characters detailsCharacter)
        {
            InitializeComponent();
            viewModel = new DescriptionPageViewModel(detailsCharacter);
            BindingContext = viewModel;
        }

    }
}