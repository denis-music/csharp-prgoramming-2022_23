namespace DLWMS.ConsoleApp.Predavanja.P3
{
    public interface IKorisnik
    {
        string KorisnickoIme { get; set; }
        string Lozinka { get; set; }
        bool Prijava();
    }

}
