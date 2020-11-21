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
	public partial class Browser : ContentPage
	{
        public string modified_title { get; set; }
        public string source { get; set; }

        private ContentView contentView = new ContentView { };

        public Browser ()
		{
            this.modified_title = "No title";

            InitializeComponent();

            Title = modified_title;
        }

        public Browser(string modified_title)
        {
            this.modified_title = modified_title;

            InitializeComponent();

            Title = modified_title;

            web_view.Source = "http://xamarin.com";
        }

        public Browser(string modified_title, string source)
        {
            this.modified_title = modified_title;
            this.source = source;

            InitializeComponent();

            Title = modified_title;

            web_view.Source = source;
        }

        private async void Undo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}