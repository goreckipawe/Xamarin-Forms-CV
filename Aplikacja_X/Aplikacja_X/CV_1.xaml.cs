using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplikacja_X
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CV_1 : ContentPage
    {
        public string modified_title { get; set; }

        private ContentView contentView = new ContentView{};

        public CV_1()
        {

            this.modified_title = "No title";
            
            contentView.Content = new Label
            {
                Text = this.modified_title,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            NavigationPage.SetTitleView(this, contentView);
            InitializeComponent();

            BindingContext = this;
        }
        public CV_1 (string modified_title)
		{
            this.modified_title = modified_title;

            contentView.Content = new Label
            {
                Text = this.modified_title,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            NavigationPage.SetTitleView(this, contentView);
            InitializeComponent();

            BindingContext = this;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}