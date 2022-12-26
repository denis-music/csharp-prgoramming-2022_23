using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;

namespace DLWMS.Data
{

    public class Uloga
    {
        public int Id { get; set; }
        public string Naziv { get; set; }

        public ICollection<Student> Student { get; set; }
        public Uloga()
        {
            Student = new HashSet<Student>();
        }
    }


    public class Student
    {
        public ICollection<Uloga> Uloga { get; set; }


        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrojIndeksa { get; set; }
        public string Lozinka { get; set; }
        public string Email { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public int GodinaStudija { get; set; }
        public byte[] Slika { get; set; }//byte[]
        public bool Aktivan { get; set; }
        //public int SpolId { get; set; }
        
        public Spol Spol { get; set; }

        public List<StudentPredmet> PolozeniPredmeti { get; set; }

        public Student()
        {
            PolozeniPredmeti = new List<StudentPredmet>();
            Uloga = new HashSet<Uloga>();
        }

        public override string ToString()
        {
            return $"({BrojIndeksa}) - {Ime} {Prezime}";
        }
    }
    /// <summary>
    /// Klase korištene za demo pojedinih koncepata OOP-a
    /// </summary>
    public class _Student
    {
        string _ime;

        int _indeks;
        public int GetIndeks() { return _indeks; }
        public void SetIndeks(int indeks) { _indeks = indeks; }
        public string Prezime { get; set; }
        public int GodinaStudija { get; set; }

        public int? MentorId { get; set; }

        public _Student() { }
        public _Student(int indeks, string ime, string prezime)
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
        private _Student[] Prijavljeni { get; set; } = new _Student[100];
        private int brojPrijavljenih = 0;
        public bool DodajStudenta(_Student student) {
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
        public _Student GetStudentByIndeks(string indeks)
        {
            //return new Student()
            //{
            //    GodinaStudija = 1,
            //    MentorId = null,
            //    Prezime = $"Student {indeks}"
            //};
            return null;
        }

        public List<_Student> GetStudentiByGodinaStudija(int godinaStudija)
        {
            return new List<_Student>()
            {
                new _Student(){Prezime = "Prezime1", GodinaStudija = godinaStudija},
                new _Student(){Prezime = "Prezime2", GodinaStudija = godinaStudija},
                new _Student(){Prezime = "Prezime3", GodinaStudija = godinaStudija},

            };
        }
    }

}