using Aplikacja_X.Database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplikacja_X
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Hobbies : ContentPage
	{
        public string modified_title { get; set; }
        private ObservableCollection<HobbiesCategories> hobbies_categories_list = new ObservableCollection<HobbiesCategories>();

        private ContentView contentView = new ContentView { };

        public Hobbies()
        {
            this.modified_title = "No title";

            InitializeComponent();

            Title = modified_title;

            hobbies_categories_list = DataDownload();
            hobbies.ItemsSource = hobbies_categories_list;
        }

        public Hobbies(string modified_title)
        {
            this.modified_title = modified_title;

            InitializeComponent();

            Title = modified_title;

            hobbies_categories_list = DataDownload();
            hobbies.ItemsSource = hobbies_categories_list;
        }

        private ObservableCollection<HobbiesCategories> DataDownload()
        {
            ObservableCollection<HobbiesCategories> hobbies_categories_temp = new ObservableCollection<HobbiesCategories>();
            var conn = DependencyService.Get<IDatabase>().DatabaseConnection(1);

            hobbies_categories_temp = DependencyService.Get<IDatabase>().HobbiesOC(1, conn);

            return hobbies_categories_temp;
        }
    }
}