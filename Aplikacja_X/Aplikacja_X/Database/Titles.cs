namespace Aplikacja_X
{
    public class Titles
    {
        private int id_e;
        private string school;
        private string school_website;
        private string direction;
        private string specialization;
        private int start_year;
        private int end_year;
        private string academic_title;

        public int Id_e { get => id_e; set => id_e = value; }
        public string School { get => school; set => school = value; }
        public string School_website { get => school_website; set => school_website = value; }
        public string Direction { get => direction; set => direction = value; }
        public string Specialization { get { if (specialization != "NULL" && specialization != "") { return specialization; } else { return "No specialization"; } } set => specialization = value; }
        public int Start_year { get => start_year; set => start_year = value; }
        public int End_year { get => end_year; set => end_year = value; }
        public string Academic_title { get => academic_title; set => academic_title = value; }

        public Titles(int id_e, string school, string school_website, string direction, string specialization, int start_year, int end_year, string academic_title)
        {
            Id_e = id_e;
            School = school;
            School_website = school_website;
            Direction = direction;
            Specialization = specialization;
            Start_year = start_year;
            End_year = end_year;
            Academic_title = academic_title;
        }
    }
}
