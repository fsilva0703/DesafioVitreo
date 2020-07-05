using Xamarin.Forms;

namespace DesafioVitreo
{
    public class SplashPage : ContentPage
    {
        Image splashImage;

        public SplashPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            var sub = new AbsoluteLayout();
            splashImage = new Image
            {
                Source = "logoMarvel.png",
                WidthRequest = 180,
                HeightRequest = 180
            };

            AbsoluteLayout.SetLayoutFlags(splashImage, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(splashImage, new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            sub.Children.Add(splashImage);

            this.BackgroundColor = Color.White;
            this.Content = sub;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await splashImage.ScaleTo(0.6, 1000);
            await splashImage.ScaleTo(0.13, 800, Easing.Linear);
            await splashImage.ScaleTo(0.9, 800, Easing.Linear);
            Application.Current.MainPage = new NavigationPage(new MainPage()) { BarBackgroundColor = Color.FromHex("#ED1D24"), BarTextColor = Color.White };
        }
    }
}
