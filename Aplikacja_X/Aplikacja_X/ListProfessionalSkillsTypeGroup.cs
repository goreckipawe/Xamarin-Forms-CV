using System.Collections.Generic;

namespace Aplikacja_X
{
    class ListProfessionalSkillsTypeGroup : List<ProfessionalSkills>
    {
        private string title;
        private string shortname;
        private string subtitle;

        public string Title { get => title; set => title = value; }
        public string Shortname { get => shortname; set => shortname = value; }
        public string Subtitle { get => subtitle; set => subtitle = value; }

        public ListProfessionalSkillsTypeGroup()
        {
        }

        public ListProfessionalSkillsTypeGroup(string title, string shortname, string subtitle)
        {
            this.Title = title;
            this.Shortname = shortname;
            this.Subtitle = subtitle;
        }
    }
}
