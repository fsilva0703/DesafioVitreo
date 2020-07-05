using Xamarin.Forms;

namespace DesafioVitreo
{
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mjc4ODE2QDMxMzgyZTMxMmUzMEY0ckpMaUtUKzgvT3BvckdkcHFQYTl0TmxrMUc5dHNOajlUR3FRTVhlY0E9;Mjc4ODE3QDMxMzgyZTMxMmUzMEhEMzduWlJSQW9GV1U3UXA0cFUzU2Z6dVZTZ3VBaTFBZkVUTkV4MXpYejA9;Mjc4ODE4QDMxMzgyZTMxMmUzMGdCZFM2UXY4czFXMXNwV0IwcWxaS21Jc2dEZGdpcE9Ta0d4Z0s0OHNWbzg9");

            InitializeComponent();

            MainPage = new NavigationPage(new SplashPage()) { BarBackgroundColor = Color.FromHex("#ED1D24"), BarTextColor = Color.White };
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
