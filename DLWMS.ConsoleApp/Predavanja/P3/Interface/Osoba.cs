namespace DLWMS.ConsoleApp.Predavanja.P3
{
    public abstract class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public Osoba(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }
        public abstract string PredstaviSe();//=0;
        public virtual string Info()
        {
            return $"{Ime} {Prezime}";
        }
    }

}
