namespace DLWMS.ConsoleApp.Predavanja.P3
{
    public class Korisnik : IKorisnik, IDisposable
    {
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }

        public void Dispose()
        {
            //_file.Close();
        }

        public bool Prijava()
        {
            Console.WriteLine("KORISNIK se prijavljuje...");
            return true;
        }
    }

}
