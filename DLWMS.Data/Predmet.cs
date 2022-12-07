namespace DLWMS.Data
{
    public class Predmet
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public override string ToString()
        {
            return Naziv; 
        }
    }

}