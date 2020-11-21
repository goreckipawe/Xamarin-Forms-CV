namespace Aplikacja_X
{
    public class Duties
    {
        private int id_d;
        private string duty;
        private string created_at;
        private string updated_at;
        private string deleted_at;

        public int Id_d { get => id_d; set => id_d = value; }
        public string Duty { get => duty; set => duty = value; }
        public string Created_at { get => created_at; set => created_at = value; }
        public string Updated_at { get => updated_at; set => updated_at = value; }
        public string Deleted_at { get => deleted_at; set => deleted_at = value; }

        public Duties(){}

        public Duties(int id_d, string duty, string created_at, string updated_at, string deleted_at)
        {
            Id_d = id_d;
            Duty = duty;
            Created_at = created_at;
            Updated_at = updated_at;
            Deleted_at = deleted_at;
        }
    }
}
