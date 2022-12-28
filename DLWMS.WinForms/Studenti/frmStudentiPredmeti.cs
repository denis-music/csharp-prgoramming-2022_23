using DLWMS.Data;
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.Intro;
using DLWMS.WinForms.Izvjestaji;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace DLWMS.WinForms.Studenti
{
    public partial class frmStudentiPredmeti : Form
    {
        private Student student;

        DLWMSDbContext db = new DLWMSDbContext();

        public frmStudentiPredmeti(Student odabraniStudent)
        {
            InitializeComponent();
            dgvPolozeniPredmeti.AutoGenerateColumns = false;
            this.student = odabraniStudent;
        }

        private void frmStudentiPredmeti_Load(object sender, EventArgs e)
        {
            UcitajPolozenePredmete();
            UcitajPodatkeOStudentu();
            UcitajPredmete();
            cmbOcjene.SelectedIndex = 0;
        }

        private void UcitajPredmete()
        {
            cmbPredmet.LoadData(db.Predmeti.ToList());
            //cmbPredmet.LoadData(InMemoryDB.Predmeti);
        }

        private void UcitajPodatkeOStudentu()
        {
            pbSlika.Image = ImageHelper.FromByteToImage(student.Slika);
            lblImePrezime.Text = $"{student.Ime} {student.Prezime}";
            lblIndeks.Text = student.BrojIndeksa;
        }

        private void UcitajPolozenePredmete()
        {
            //Polozeni = (dgvPolozeniPredmeti.DataSource as BindingSource).DataSource as List<StudentPredmet>

            var binding = new BindingSource();
            binding.DataSource = db.StudentiPredmeti.Where(
                polozeni => polozeni.StudentId == student.Id).ToList(); //odabraniStudent.PolozeniPredmeti;
            //dgvPolozeniPredmeti.DataSource = null;
            dgvPolozeniPredmeti.DataSource = binding;
            //dgvPolozeniPredmeti.DataSource = odabraniStudent.PolozeniPredmeti;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (ValidanUnos())
            {

                var predmet = cmbPredmet.SelectedItem as Predmet;
                
                if (PredmetVecDodat())
                {
                    var poruka = Resursi.Get(Kljucevi.PodatakVecPostoji);//Podatak {0} je već {1} dodat
                    var ispis = string.Format(poruka, predmet.Naziv);//Podatak Programiranj I je već dodat
                    MessageBox.Show(ispis,"Informacija",MessageBoxButtons.OK, MessageBoxIcon.Information);//<<<<<
                    return;
                }

                var polozeni = new StudentPredmet()
                {
                  //  Id = odabraniStudent.PolozeniPredmeti.Count() + 1,
                    Datum    = dtpDatumPolaganja.Value,
                    Ocjena = int.Parse(cmbOcjene.Text),
                    PredmetId = predmet.Id,
                    StudentId = student.Id
                };
                //  odabraniStudent.PolozeniPredmeti.Add(polozeni);
                db.StudentiPredmeti.Add(polozeni);
                db.SaveChanges();

                UcitajPolozenePredmete();
            }
        }

        private bool PredmetVecDodat()
        {
            var odabraniPredmet = cmbPredmet.SelectedItem as Predmet;//1 Programiranje I
            return db.StudentiPredmeti.Where( 
                polozeni => polozeni.PredmetId == odabraniPredmet.Id
                && polozeni.StudentId == student.Id
                ).Count() > 0;

        }

        private bool ValidanUnos()
        {
            return      Validator.ValidirajKontrolu(cmbPredmet, err, Kljucevi.ObaveznaVrijednost)
                 &&     Validator.ValidirajKontrolu(cmbOcjene, err, Kljucevi.ObaveznaVrijednost);
        }

        private void btnPrintaj_Click(object sender, EventArgs e)
        {
            var podaciZaPrint = new dtoUvjerenjOPolozenim()
            {
                BrojIndeksa = student.BrojIndeksa,
                ImePrezime = $"{student.Ime} {student.Prezime}",
                Status  = "REDOVAN",
                AkademskaGodina = "2022/2023",
                Polozeni = (dgvPolozeniPredmeti.DataSource as BindingSource).DataSource as List<StudentPredmet>
            };

            var frmIzvjestaji = new frmIzvjestaji(podaciZaPrint);
            frmIzvjestaji.ShowDialog();

        }
    }

    public class dtoUvjerenjOPolozenim
    {
        public string BrojIndeksa { get; set; }
        public string ImePrezime { get; set; }
        public string Status { get; set; }
        public string AkademskaGodina{ get; set; }

        public List<StudentPredmet> Polozeni { get; set; }
    }


}
