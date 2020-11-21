using Xamarin.Forms;

namespace Aplikacja_X
{
    public class ProfessionalSkills
    {
        private string text;
        private string detail;
        private Xamarin.Forms.ImageSource imageSource;
        private string link;

        public string Text { get => text; set => text = value; }
        public string Detail { get => detail; set => detail = value; }
        public ImageSource ImageSource { get => imageSource; set => imageSource = value; }
        public string Link { get => link; set => link = value; }

        public ProfessionalSkills(){}

        public ProfessionalSkills(string text, string detail, ImageSource imageSource, string link)
        {
            this.Text = text;
            this.Detail = detail;
            ImageSource = imageSource;
            this.Link = link; 
        }
    }
}
