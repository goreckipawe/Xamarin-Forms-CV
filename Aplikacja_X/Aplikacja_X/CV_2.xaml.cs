using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplikacja_X
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CV_2 : ContentPage
	{
        public string modified_title { get; set; }
        public string modified_title_label
        {
            get { return modified_title; }
            set
            {
                modified_title = value;
                OnPropertyChanged(nameof(modified_title_label));
            }
        }
        private ContentView contentView = new ContentView{};

        public CV_2()
        {
            
            this.modified_title = "No title";
            modified_title_label = "No title";
            contentView.Content = new Label
            {
                Text = modified_title,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            //Title = "MyPage";

            NavigationPage.SetTitleView(this, contentView);
            InitializeComponent();
            //subtitle.Text = "This is subtitle";

        }
        public CV_2 (string modified_title)
		{
            this.modified_title = modified_title;
            modified_title_label = modified_title;
            contentView.Content = new Label
            {
                Text = modified_title,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            NavigationPage.SetTitleView(this, contentView);
            InitializeComponent();
            //subtitle.Text = "This is subtitle";

        }
	}
}