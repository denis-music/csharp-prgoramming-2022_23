using System.Reflection.PortableExecutable;

namespace DLWMS.Data
{

    public class InMemoryDB
    {
        public static List<Korisnik> Korisnici = GenerisiKorisnike();
        public static List<Student> Studenti = GenerisiStudente();
        public static List<GodinaStudija> GodineStudija = GenerisiGodineStudija();
        public static List<Spol> Spolovi = GenerisiSpolove();
        public static List<Predmet> Predmeti = GenerisiPredmete();

        private static List<Predmet> GenerisiPredmete()
        {
            return new List<Predmet>() {
                    new Predmet()  { Id = 1, Naziv = "Matematika"  },
                    new Predmet()  { Id = 2, Naziv = "Programiranje I"  },
                    new Predmet()  { Id = 3, Naziv = "Marketing"  },
                    new Predmet()  { Id = 4, Naziv = "Operativni sistemi"  }
            };
        }

        private static List<Spol> GenerisiSpolove()
        {
            return new List<Spol>() {
                    new Spol()  { Id = 1, Naziv = "********"  },
                    new Spol()  { Id = 2, Naziv = "Ženski"  },
                    new Spol()  { Id = 3, Naziv = "Muški"  }
            };
        }

        private static List<GodinaStudija> GenerisiGodineStudija()
        {
            return new List<GodinaStudija>() {
                    new GodinaStudija()  { Id = 1, Aktivna = true, Oznaka= "1 - GODINA", Opis = "Prva godina studija"  },
                    new GodinaStudija()  { Id = 2, Aktivna = true, Oznaka= "2 - GODINA", Opis = "Druga godina studija"  },
                    new GodinaStudija()  { Id = 3, Aktivna = true, Oznaka= "3 - GODINA", Opis = "Treca godina studija"  },
                    new GodinaStudija()  { Id = 4, Aktivna = true, Oznaka= "4 - GODINA", Opis = "Cetvrta godina studija"  }

            };            
        }
        private static List<Student> GenerisiStudente()
        {
            return new List<Student>() {
                    new Student()  {
                        Id = 1,
                        Aktivan = true,
                        Email = "denis@edu.fit.ba",
                        Ime = "Denis",
                        Prezime = "Music",
                        BrojIndeksa = "IB210021",
                        Lozinka = "denis",
                        DatumRodjenja = new DateTime(2000,2,2),
                        GodinaStudija = 1,
                        Slika = null           
                    },
                    new Student()  {
                        Id = 2,
                        Aktivan = true,
                        Email = "jasmin@edu.fit.ba",
                        Ime = "Jasmin",
                        Prezime = "Azemovic",
                        BrojIndeksa = "IB210022",
                        Lozinka = "jasmin",
                        DatumRodjenja = new DateTime(2000,3,3),
                        GodinaStudija = 1,
                        Slika = null
                    }
            };
        }
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
}