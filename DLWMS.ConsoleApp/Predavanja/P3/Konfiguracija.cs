namespace DLWMS.ConsoleApp.Predavanja.P3
{
    public class Konfiguracija
    {
        public const string Naziv = "DLWMS - Distance Learning Web Management System";
        public readonly string KonekcijskiString;

        public Konfiguracija(string konekcijskiString) 
        {
            KonekcijskiString = konekcijskiString;
        }
    }

}
