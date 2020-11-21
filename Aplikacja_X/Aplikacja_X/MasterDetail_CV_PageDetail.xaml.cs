using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplikacja_X
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetail_CV_PageDetail : ContentPage
    {
        public MasterDetail_CV_PageDetail()
        {
            InitializeComponent();
        }

        public string get_information()
        {
            string si = DependencyService.Get<SystemInformation>().GetOsVersion();
            return si;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var result = await this.DisplayAlert("Close", "You want to close the application?", "Yes", "No");

            if (result) {
                DependencyService.Get<CloseApplication>().closeApplication();
            }
        }
    }
}