using Xamarin.Forms;

namespace Aplikacja_X.Database
{
    public class HobbiesCategories
    {
        private int id_hc;
        private string name;
        private string picture;
        private string description;
        private int order;
        private ImageSource picture_image_source;

        public int Id_hc { get => id_hc; set => id_hc = value; }
        public string Name { get => name; set => name = value; }
        public string Picture { get => picture; set => picture = value; }
        public string Description { get => description; set => description = value; }
        public int Order { get => order; set => order = value; }
        public ImageSource Picture_image_source { get => picture_image_source; set => picture_image_source = value; }

        public HobbiesCategories() { }

        public HobbiesCategories(int id_hc, string name, string picture, string description, int order, ImageSource picture_image_source)
        {
            Id_hc = id_hc;
            Name = name;
            Picture = picture;
            Description = description;
            Order = order;
            Picture_image_source = picture_image_source;
        }
    }
}
