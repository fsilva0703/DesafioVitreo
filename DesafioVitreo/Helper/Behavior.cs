using DesafioVitreo.Model;
using DesafioVitreo.View;
using Syncfusion.ListView.XForms;
using System;
using Xamarin.Forms;

namespace DesafioVitreo.Helper
{
    public class Behavior : Behavior<ContentPage>
    {
        #region Fields

        SfListView ListView;
        SearchBar SearchBar;
        #endregion

        #region Overrides
        protected override void OnAttachedTo(ContentPage bindable)
        {
            ListView = bindable.FindByName<SfListView>("listView");
            SearchBar = bindable.FindByName<SearchBar>("filterText");
            SearchBar.TextChanged += SearchBar_TextChanged;
            ListView.SelectionController = new SelectionControllerExt(ListView);
            ListView.SelectionChanged += SFlistView_SelectionChanged;
            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(ContentPage bindable)
        {
            SearchBar.TextChanged -= SearchBar_TextChanged;
            SearchBar = null;
            ListView = null;
            base.OnDetachingFrom(bindable);
        }

        #endregion

        #region Methods

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (ListView.ItemsSource != null && (e.NewTextValue.Length >= 3 || e.NewTextValue.Length == 0))
            {
                ListView.DataSource.Filter = FilterContacts;
                ListView.DataSource.RefreshFilter();
            }
            ListView.RefreshView();
        }

        private bool FilterContacts(object obj)
        {
            if (SearchBar == null || SearchBar.Text == null)
                return true;

            var characters = obj as Characters;
            return (characters.Name.ToLower().Contains(SearchBar.Text.ToLower()));
        }

        private async void SFlistView_SelectionChanged(object sender, ItemSelectionChangedEventArgs e)
        {
            Characters detailsCharacter = (Characters)e.AddedItems[0];
            await Application.Current.MainPage.Navigation.PushModalAsync(new DescriptionPage(detailsCharacter));
        }

        #endregion
    }
}
