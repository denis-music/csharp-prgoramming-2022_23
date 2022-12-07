namespace DLWMS.Data
{
    public class PolozeniPredmet
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public Predmet Predmet { get; set; }
        public int Ocjena { get; set; }
    }

}