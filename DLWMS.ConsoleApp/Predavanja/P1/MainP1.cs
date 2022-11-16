using DLWMS.Data;

namespace DLWMS.ConsoleApp.Predavanja.P1
{
    public class MainP1
    {
        public static void Pokreni()
        {
            //TipoviPodataka();
            //Pokazivaci();
            //Klase();
            //VrsteTipovaPodataka();
            //BazniTip();
            //NovaVerzijaMetode();
            //KonekcijaNaBazu();
        }

        private static void KonekcijaNaBazu()
        {
            Konekcija konekcija = new Konekcija();
            List<_Student> studenti = konekcija.GetStudentiByGodinaStudija(1);
            foreach (var student in studenti)
            {
                Console.WriteLine(student);
            }
        }

        private static void NovaVerzijaMetode()
        {
            _Student denis = new _Student(220022, "Denis", "Music");
            Console.WriteLine(denis);
            Console.WriteLine(denis.ToString());

        }

        private static void BazniTip()
        {
            int indeks2 = 222000;
            _Student denis = new _Student(220022, "Denis", "Music");

            object objIndeks = indeks2;
            object objStudent = denis;
            Prikazi(indeks2);
            Prikazi(denis);

        }

        private static void Prikazi(object objIndeks)
        {
            throw new NotImplementedException();
        }

        private static void VrsteTipovaPodataka()
        {
            int indeks1 = 220022;
            int indeks2 = indeks1;
            indeks1 = 222000;

            _Student denis = new _Student(220022, "Denis", "Music");
            _Student student = denis;
            student.Prezime = "STUDENT";


        }

        private static void Klase()
        {
            _Student denis = new _Student(220022, "Denis", "Music");
            Console.WriteLine(denis.GetIndeks());
            denis.SetIndeks(220033);
            Console.WriteLine(denis.GetIndeks());
            denis.Prezime = "TEST";

            _Student zanin = new _Student(indeks: 220023, prezime: "Vejzovic", ime: "Zanin");
            _Student jasmin = new _Student()
            {
                Prezime = "Azemovic",
                GodinaStudija = 1
            };
        }

        private static void Pokazivaci()
        {
            int indeks = 220022;
            unsafe
            {
                int* p = &indeks;
                *p = 220021;
            }
        }

        private static void TipoviPodataka()
        {
            int indeks = 220022;
            string imePrezime = "Denis Music";
            bool aktivan = false;
            double skolarina = 2000;

            Console.WriteLine($"{indeks} je student {imePrezime} aktivan {aktivan} skolarian {skolarina}");
        }
    }
}
