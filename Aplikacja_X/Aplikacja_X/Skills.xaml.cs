using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplikacja_X
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Skills : ContentPage
	{
        public string modified_title { get; set; }

        private ContentView contentView = new ContentView {};

        private List<ListProfessionalSkillsTypeGroup> lpstg = new List<ListProfessionalSkillsTypeGroup>();

        public Skills ()
		{
            this.modified_title = "No title";

            InitializeComponent ();

            Title = modified_title;

            lpstg = get_lps();

            professional_skills.ItemsSource = lpstg;
        }

        public Skills(string modified_title)
        {
            this.modified_title = modified_title;

            InitializeComponent();

            Title = modified_title;

            lpstg = get_lps();

            professional_skills.ItemsSource = lpstg;
        }

        private List<ListProfessionalSkillsTypeGroup> get_lps() {
            List<ListProfessionalSkillsTypeGroup> listProfessionalSkillsTypeGroup = new List<ListProfessionalSkillsTypeGroup>();

            listProfessionalSkillsTypeGroup.Add(new ListProfessionalSkillsTypeGroup("Programming language", "pl", "Programming language") {
                new ProfessionalSkills("JavaScript", "Programming language", ImageSource.FromResource("Aplikacja_X.Images.js.png"), "https://developer.mozilla.org/pl/docs/Web/JavaScript"),
                new ProfessionalSkills("PHP", "Programming language", ImageSource.FromResource("Aplikacja_X.Images.php.png"), "https://www.php.net"),
                new ProfessionalSkills("TypeScript", "Programming language", ImageSource.FromResource("Aplikacja_X.Images.ts.png"), "https://www.typescriptlang.org"),
                new ProfessionalSkills("MySQL", "Programming language", ImageSource.FromResource("Aplikacja_X.Images.mysql.png"), "https://www.mysql.com"),
                new ProfessionalSkills("Android", "Programming language", ImageSource.FromResource("Aplikacja_X.Images.android.jpg"), "https://developer.android.com/docs"),
                new ProfessionalSkills("C#", "Programming language", ImageSource.FromResource("Aplikacja_X.Images.csharp.png"), "https://docs.microsoft.com/pl-pl/dotnet/csharp/"),
                new ProfessionalSkills("Java", "Programming language", ImageSource.FromResource("Aplikacja_X.Images.java.png"), "https://docs.oracle.com/en/java/"),
                new ProfessionalSkills("SQL", "Programming language", ImageSource.FromResource("Aplikacja_X.Images.sql.jpg"), "https://docs.oracle.com/cd/E12151_01/index.htm"),
                new ProfessionalSkills("SQLite", "Programming language", ImageSource.FromResource("Aplikacja_X.Images.sqlite.png"), "https://www.sqlite.org/index.html"),
                new ProfessionalSkills("XML", "Programming language", ImageSource.FromResource("Aplikacja_X.Images.xml.png"), "https://en.wikipedia.org/wiki/XML"),
                new ProfessionalSkills("HTML", "Programming language", ImageSource.FromResource("Aplikacja_X.Images.html.jpg"), "https://en.wikipedia.org/wiki/HTML"),
                new ProfessionalSkills("Sass", "Programming language", ImageSource.FromResource("Aplikacja_X.Images.sass.png"), "https://sass-lang.com"),
                new ProfessionalSkills("CSS", "Programming language", ImageSource.FromResource("Aplikacja_X.Images.css.png"), "https://en.wikipedia.org/wiki/Cascading_Style_Sheets"),
                new ProfessionalSkills("ASP.NET MVC", "Framework", ImageSource.FromResource("Aplikacja_X.Images.asp.net_mvc.jpeg"), "https://dotnet.microsoft.com/apps/aspnet/mvc")
            });

            listProfessionalSkillsTypeGroup.Add(new ListProfessionalSkillsTypeGroup("Framework", "f", "Framework") {
                new ProfessionalSkills("Angular", "Framework", ImageSource.FromResource("Aplikacja_X.Images.angular.png"), "https://angular.io"),
                new ProfessionalSkills("Laravel", "Framework", ImageSource.FromResource("Aplikacja_X.Images.laravel.png"), "https://laravel.com"),
                new ProfessionalSkills("NativeScript", "Framework", ImageSource.FromResource("Aplikacja_X.Images.ns.png"), "https://nativescript.org")
            });

            return listProfessionalSkillsTypeGroup;
        }

        private async void MenuItem_Clicked(object sender, EventArgs e)
        {
            var mi = sender as ImageCell;
            var ps = mi.CommandParameter as ProfessionalSkills;

            await Navigation.PushAsync(new Browser(ps.Text, ps.Link));
        }
    }
}