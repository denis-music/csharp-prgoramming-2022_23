using System.ComponentModel.DataAnnotations.Schema;

namespace DLWMS.Data
{
    [Table("StudentiPredmeti")]
    public class StudentPredmet
    {
        public int Id { get; set; }
        public DateTime Datum { get; set; }
        public int PredmetId { get; set; }
        public Predmet Predmet { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int Ocjena { get; set; }
    }

}