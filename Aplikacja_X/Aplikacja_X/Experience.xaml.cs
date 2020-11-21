using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplikacja_X
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Experience : ContentPage
	{
        public string modified_title { get; set; }
        private ObservableCollection<Jobs> jobs_list = new ObservableCollection<Jobs>();

        private ContentView contentView = new ContentView { };

        public Experience()
        {
            this.modified_title = "No title";

            InitializeComponent();

            Title = modified_title;

            jobs_list = DataDownload();
            experience.ItemsSource = jobs_list;
        }

        public Experience(string modified_title)
        {
            this.modified_title = modified_title;

            InitializeComponent();

            Title = modified_title;

            jobs_list = DataDownload();
            experience.ItemsSource = jobs_list;
        }

        private ObservableCollection<Jobs> DataDownload()
        {
            ObservableCollection<Jobs> jobs_list_temp = new ObservableCollection<Jobs>();
            var conn = DependencyService.Get<IDatabase>().DatabaseConnection(1);

            jobs_list_temp = DependencyService.Get<IDatabase>().JobList(1, conn);

            return jobs_list_temp;
        }

        async private void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            Label web_page = (Label)sender;
            if (web_page.Text != "No website available") {
                await Navigation.PushAsync(new Browser(web_page.Text, "https://" + web_page.Text));
            }
        }
    }
}