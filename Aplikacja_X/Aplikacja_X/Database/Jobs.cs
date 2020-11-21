using Xamarin.Forms;

namespace Aplikacja_X
{
    public class Jobs
    {
        private int id_j;
        private string name;
        private string business;
        private string page;
        private string start_date;
        private string end_date;
        private string city;
        private string country;
        private string created_at;
        private string updated_at;
        private string deleted_at;
        private ImageSource picture_image_source;

        public int Id_j { get => id_j; set => id_j = value; }
        public string Name { get => name; set => name = value; }
        public string Business { get => business; set => business = value; }
        public string Page { get => page; set => page = value; }
        public string Start_date { get => start_date; set => start_date = value; }
        public string End_date { get => end_date; set => end_date = value; }
        public string City { get => city; set => city = value; }
        public string Country { get => country; set => country = value; }
        public string Created_at { get => created_at; set => created_at = value; }
        public string Updated_at { get => updated_at; set => updated_at = value; }
        public string Deleted_at { get => deleted_at; set => deleted_at = value; }
        public ImageSource Picture_image_source { get => picture_image_source; set => picture_image_source = value; }

        public Jobs() { }

        public Jobs(int id_j, string name, string business, string page, string start_date, string end_date, string city, string country, string created_at, string updated_at, string deleted_at, ImageSource picture_image_source)
        {
            Id_j = id_j;
            Name = name;
            Business = business;
            Page = page;
            Start_date = start_date;
            End_date = end_date;
            City = city;
            Country = country;
            Created_at = created_at;
            Updated_at = updated_at;
            Deleted_at = deleted_at;
            Picture_image_source = picture_image_source;
        }
    }
}
