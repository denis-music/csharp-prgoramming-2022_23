namespace DLWMS.Data
{

    public class InMemoryDB
    {
        public static List<Korisnik> Korisnici = GenerisiKorisnike();

        private static List<Korisnik> GenerisiKorisnike()
        {

            //var korisnik = new Korisnik()
            //{
            //    Id = 1,
            //    Aktivan = true,
            //    Email = "admin@edu.fit.ba",
            //    Ime = "Administrator",
            //    Prezime = "FIT",
            //    KorisnickoIme = "admin",
            //    Lozinka = "admin"
            //};
            //var lista = new List<Korisnik>();
            //lista.Add(korisnik);
            //return lista;

            return new List<Korisnik>() {
                    new Korisnik()  {
                        Id = 1,
                        Aktivan = true,
                        Email = "admin@edu.fit.ba",
                        Ime = "Administrator",
                        Prezime = "FIT",
                        KorisnickoIme = "admin",
                        Lozinka = "admin"
                    }
            };
        }
    }

    public class Korisnik
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string Email { get; set; }
        public bool Aktivan { get; set; }

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}