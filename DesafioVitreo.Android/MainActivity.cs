using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using DesafioVitreo.Domain.Interface;
using DesafioVitreo.Domain.Interface.Utils;
using DesafioVitreo.Domain.Service;
using DesafioVitreo.Domain.Utils;
using Xamarin.Forms;

namespace DesafioVitreo.Droid
{
    [Activity(Label = "DesafioVitreo", Icon = "@mipmap/iconMarvel", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            DependencyService.Register<IUtils, Utils>();
            DependencyService.Register<ICharactersService, CharactersService>();

            Forms.Init(this, savedInstanceState);
            LoadApplication(new App());

            Window.SetStatusBarColor(Android.Graphics.Color.ParseColor("#ED1D24"));
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}