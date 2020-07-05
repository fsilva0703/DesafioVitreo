using Syncfusion.ListView.XForms;
using Xamarin.Forms;

namespace DesafioVitreo.Helper
{
    public class SelectionControllerExt : SelectionController
    {
        public SelectionControllerExt(SfListView listView) : base(listView)
        {
        }

        protected async override void AnimateSelectedItem(ListViewItem selectedListViewItem)
        {
            base.AnimateSelectedItem(selectedListViewItem);
            selectedListViewItem.Opacity = 0;
            await selectedListViewItem.FadeTo(1, 3000, Easing.SinInOut);
        }
    }
}
