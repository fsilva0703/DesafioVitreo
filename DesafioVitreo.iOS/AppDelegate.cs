using DesafioVitreo.Domain.Interface;
using DesafioVitreo.Domain.Interface.Utils;
using DesafioVitreo.Domain.Service;
using DesafioVitreo.Domain.Utils;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Syncfusion.XForms.iOS.Cards;

namespace DesafioVitreo.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            DependencyService.Register<IUtils, Utils>();
            DependencyService.Register<ICharactersService, CharactersService>();
            Forms.Init();

            Syncfusion.ListView.XForms.iOS.SfListViewRenderer.Init();
            SfCardViewRenderer.Init();

            LoadApplication(new App());

            UIView statusBar = UIApplication.SharedApplication.ValueForKey(new NSString("statusBar")) as UIView;
            if (statusBar != null && statusBar.RespondsToSelector(new ObjCRuntime.Selector("setBackgroundColor:")))
            {
                statusBar.BackgroundColor = Color.FromHex("#ED1D24").ToUIColor();
            }

            return base.FinishedLaunching(app, options);
        }
    }
}
