using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplikacja_X
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Education : ContentPage
	{
        public string modified_title { get; set; }
        private List<Titles> titles_list = new List<Titles>();

        private ContentView contentView = new ContentView { };

        public Education()
        {
            this.modified_title = "No title";

            InitializeComponent();

            Title = modified_title;

            titles_list = DataDownload();
            education.ItemsSource = titles_list;
        }

        public Education(string modified_title)
        {
            this.modified_title = modified_title;

            InitializeComponent();

            Title = modified_title;

            titles_list = DataDownload();
            education.ItemsSource = titles_list;
        }

        private List<Titles> DataDownload()
        {
            List<Titles> titles_list_temp = new List<Titles>();
            var conn = DependencyService.Get<IDatabase>().DatabaseConnection(1);

            titles_list_temp = DependencyService.Get<IDatabase>().TitleList(1, conn);

            return titles_list_temp;
        }
    }
}