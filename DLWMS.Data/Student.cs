namespace DLWMS.Data
{
    public class Student
    {
        string _ime;

        int _indeks;
        public int GetIndeks() { return _indeks; }
        public void SetIndeks(int indeks) { _indeks = indeks; }
        public string Prezime { get; set; }
        public int GodinaStudija { get; set; }

        public int? MentorId { get; set; }

        public Student() { }
        public Student(int indeks, string ime, string prezime)
        {
            _indeks = indeks;
            _ime = ime;
            Prezime = prezime;
        }

        public override string ToString()
        {
            //return $"|{_indeks}) | {_ime} |{Prezime}| {GodinaStudija}|";

            return $"({_indeks}) -> {_ime} {Prezime} godina ({GodinaStudija})";
        }

        public void Deconstruct(out string prezime, out int godinaStudija)
        {
            prezime = Prezime;
            godinaStudija = GodinaStudija;
        }

        int[] Ocjene = new int[30];

        public int this[int lokacija] {
            get { return Ocjene[lokacija]; }
            set { Ocjene[lokacija] = value; }
        }
    }
    public struct DLStudent
    {
        public string Prezime { get; set; }
        public int GodinaStudija { get; set; }

        public override string ToString()
        {
            //return $"|{_indeks}) | {_ime} |{Prezime}| {GodinaStudija}|";

            return $" {Prezime} godina ({GodinaStudija})";
        }
    }
    public class PrijaveIspita
    {
        public string NazivIspita { get; set; }
        public DateTime DatumIspita { get; set; }
        private Student[] Prijavljeni { get; set; } = new Student[100];
        private int brojPrijavljenih = 0;
        public bool DodajStudenta(Student student) {
            Prijavljeni[brojPrijavljenih] = student;
            return true;
        }
        public override string ToString()
        {
            string tabelaPrijavljenih = "|RB|Indeks|Ime|Prezime|Godina studija|\n";
            for (int i = 0; i < brojPrijavljenih; i++)
            {
                tabelaPrijavljenih += Prijavljeni[i].ToString();
            }
            tabelaPrijavljenih += "\n----------------------------------\n";
            return tabelaPrijavljenih;
        }

    }

    public class Konekcija
    {
        public Student GetStudentByIndeks(string indeks)
        {
            //return new Student()
            //{
            //    GodinaStudija = 1,
            //    MentorId = null,
            //    Prezime = $"Student {indeks}"
            //};
            return null;
        }

        public List<Student> GetStudentiByGodinaStudija(int godinaStudija)
        {
            return new List<Student>()
            {
                new Student(){Prezime = "Prezime1", GodinaStudija = godinaStudija},
                new Student(){Prezime = "Prezime2", GodinaStudija = godinaStudija},
                new Student(){Prezime = "Prezime3", GodinaStudija = godinaStudija},

            };
        }
    }

}