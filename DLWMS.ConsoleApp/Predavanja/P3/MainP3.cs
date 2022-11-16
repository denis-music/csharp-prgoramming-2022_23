using DLWMS.Data;

namespace DLWMS.ConsoleApp.Predavanja.P3
{    

    internal class MainP3
    {
        static ILogger _logger;
        public static void Pokreni(ILogger logger)
        {
            //Nasljedjivanje();
            //Interfejsi();
            //_logger = logger;
            //Logiranje();
            //Repository();
            //DisposableInterfejs();
        }

        private static void DisposableInterfejs()
        {
            using (var sr = new Korisnik())
            {

            }
            //using (var sr = new StreamReader(""))
            //{

            //}
        }
        private static void Repository()
        {
            StudentRepository studentDB = new StudentRepository();
            _Student denis = new _Student() { GodinaStudija = 1, MentorId = null, Prezime = "Music" };
            studentDB.Save(denis);
            var studentId2 = studentDB.GetById(2);

            var korisnikDB = new KorisnikRepository();
            korisnikDB.Save(new Korisnik() { KorisnickoIme = "denis.music", Lozinka = "Test1111" });
        }
        private static void Logiranje()
        {
            try
            {
                throw new Exception("Namjerni izuzetak!!!");
            }
            catch (Exception ex)
            {
                _logger.Log(ex);                
            }
        }
        private static void Interfejsi()
        {
            IKorisnik korisnik = new Korisnik();
            //public class DLStudent : Osoba, IStudent
            IStudent dlStudent = new DLStudent("IB150051", "Denis", "Music");

            PrijaviKorisnika(korisnik);
            PrijaviKorisnika(dlStudent);
            _logger.Log("Savladali smo interfejse...");
        }
        private static void PrijaviKorisnika(IKorisnik korisnik)
        {
            korisnik.Prijava();
            _logger.Log("Korisnik prijavljen");
        }
        private static void Nasljedjivanje()
        {
            //Osoba osoba = new Osoba("Denis","Music");
            Osoba dlStudent = new DLStudent("IB150051", "Denis", "Music");

            // OsobaInfo(osoba);
            OsobaInfo(dlStudent);
        }
        private static void OsobaInfo(Osoba osoba)
        {
            if (osoba is DLStudent)
            {
                var indeks = (osoba as DLStudent).Indeks;

            }

        }
    }
}
