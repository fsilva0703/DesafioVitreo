using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DesafioVitreo.Helper
{
    public class NavigationBehavior : Behavior<ContentPage>
    {
        #region Fields

        Button BackButton;
        #endregion

        #region Overrides
        protected override void OnAttachedTo(ContentPage bindable)
        {
            BackButton = bindable.FindByName<Button>("backButton");
            BackButton.Clicked += Back_Clicked;
            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(ContentPage bindable)
        {
            BackButton = null;
            base.OnDetachingFrom(bindable);
        }

        #endregion

        #region Methods

        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PopModalAsync();
        }

        #endregion
    }
}
