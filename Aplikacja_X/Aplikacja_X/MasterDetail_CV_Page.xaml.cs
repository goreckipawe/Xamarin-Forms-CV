using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplikacja_X
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetail_CV_Page : MasterDetailPage
    {
        public MasterDetail_CV_Page()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterDetail_CV_PageMenuItem;
            if (item == null)
                return;

            if (item.Title == "Close") {
                var result = await this.DisplayAlert("Close", "You want to close the application?", "Yes", "No");

                if (result)
                {
                    DependencyService.Get<CloseApplication>().closeApplication();
                }
            } else {
                Detail = new NavigationPage(item.Page);
            }
           
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }
    }
}