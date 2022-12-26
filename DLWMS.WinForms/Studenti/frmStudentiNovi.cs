using DLWMS.Data;
using DLWMS.WinForms.Helpers;
using DLWMS.WinForms.Intro;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms.Studenti
{
    public partial class frmStudentiNovi : Form
    {
        private Student student;
        DLWMSDbContext db = new DLWMSDbContext();

        public frmStudentiNovi(Student odabraniStudent = null)
        {
            InitializeComponent();
            student = odabraniStudent ?? new Student();
            dgvUloge.AutoGenerateColumns = false;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (ValdanUnos())
            {

                student.Aktivan = cbAktivan.Checked;
                student.BrojIndeksa = txtBrojIndeksa.Text;
                student.DatumRodjenja = dtpDatumRodjenja.Value;
                student.Email = txtEmail.Text;
                student.GodinaStudija = (int)cmbGodinaStudija.SelectedValue;
                student.Ime = txtIme.Text;
                student.Prezime = txtPrezime.Text;
                student.Slika = ImageHelper.FromImageToByte(pbSlikaStudenta.Image);
                student.Lozinka = txtLozinka.Text;
                student.Spol = cmbSpol.SelectedItem as Spol;

                var poruka = Kljucevi.PodaciUspjesnoModifikovani;

                if (student.Id == 0)
                {
                    //student.Id = InMemoryDB.Studenti.Count + 1;
                    poruka = Kljucevi.PodaciUspjesnoDodati;
                    //InMemoryDB.Studenti.Add(student);
                    db.Studenti.Add(student);
                }else
                    db.Entry(student).State = EntityState.Modified;

                db.SaveChanges();

                MessageBox.Show($"{Resursi.Get(poruka)} {student}",
                                  Resursi.Get(Kljucevi.Informacija),
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();

            }
        }

        private bool ValdanUnos()
        {
            return Validator.ValidirajKontrolu(txtIme, err, Kljucevi.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtPrezime, err, Kljucevi.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(cmbGodinaStudija, err, Kljucevi.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtBrojIndeksa, err, Kljucevi.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtEmail, err, Kljucevi.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtLozinka, err, Kljucevi.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(pbSlikaStudenta, err, Kljucevi.ObaveznaVrijednost);
        }

        private void frmStudentiNovi_Load(object sender, EventArgs e)
        {
            UcitajGodineStudija();
            UcitajSpolove();
            UcitajUloge();
            if (student.Id == 0)
                NoviStudent();
            else
                UcitajPodatkeOStudentu();
        }

        private void UcitajUloge()
        {
            cmbUloge.LoadData(db.Uloge.ToList());
        }

        private void UcitajSpolove()
        {

            cmbSpol.LoadData(db.Spolovi.ToList());

            //cmbSpol.LoadData(InMemoryDB.Spolovi);

            //DataLoader.ToComboBox(cmbSpol, InMemoryDB.Spolovi);

            //cmbSpol.DataSource = InMemoryDB.Spolovi;
            //cmbSpol.DisplayMember = "Naziv";
            //cmbSpol.ValueMember = "Id";
        }

        private void UcitajGodineStudija()
        {

            cmbGodinaStudija.LoadData(InMemoryDB.GodineStudija);

            //DataLoader.ToComboBox(cmbGodinaStudija, InMemoryDB.GodineStudija, "Oznaka");

            //cmbGodinaStudija.DataSource = InMemoryDB.GodineStudija;
            //cmbGodinaStudija.DisplayMember = "Oznaka";
            //cmbGodinaStudija.ValueMember = "Id";

        }

        private void UcitajPodatkeOStudentu()
        {
            cbAktivan.Checked = student.Aktivan;
            txtBrojIndeksa.Text = student.BrojIndeksa ;
            dtpDatumRodjenja.Value = student.DatumRodjenja;
            txtEmail.Text = student.Email ;
            cmbGodinaStudija.SelectedValue = student.GodinaStudija;
            txtIme.Text = student.Ime;
            txtPrezime.Text = student.Prezime;
            pbSlikaStudenta.Image = ImageHelper.FromByteToImage(student.Slika);
            txtLozinka.Text = student.Lozinka;
            cmbSpol.SelectedValue  = student.Spol?.Id;
            UcitajUlogeStudenta();

        }

        private void UcitajUlogeStudenta()
        {
            dgvUloge.DataSource = null;
            dgvUloge.DataSource = student.Uloga.ToList();
        }

        private void NoviStudent()
        {
            GenerisiBrojIndeksa();
            GenerisiLozinku();
            OznaciAktivnogStudenta();
        }

        private void OznaciAktivnogStudenta()
        {
            cbAktivan.Checked = true;
        }

        private void GenerisiLozinku()
        {
            txtLozinka.Text = Generator.GenerisiLozinku();
        }

        private void GenerisiBrojIndeksa()
        {                           //IB (21) * 10000 + 3
            txtBrojIndeksa.Text = $"IB{(DateTime.Now.Year - 2000) * 10000 + db.Studenti.Count() + 1}";
        }

        private void GenerisiPodatke()
        {
            txtEmail.Text = $"{txtIme.Text}.{txtPrezime.Text}@edu.fit.ba".ToLower();
        }


       

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            GenerisiPodatke();
        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            GenerisiPodatke();
        }

        private void btnUcitajSliku_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                pbSlikaStudenta.Image = Image.FromFile(openFileDialog1.FileName);
        }

        private void btnDodajUlogu_Click(object sender, EventArgs e)
        {
            var odabranaUloga = cmbUloge.SelectedItem as Uloga;
            student.Uloga.Add(odabranaUloga);
            UcitajUlogeStudenta();
        }
    }

    public class DataLoader
    {
        public static void ToComboBox<T>(ComboBox comboBox, List<T> dataSource,
            string displayMember ="Naziv", string valueMember = "Id")
        {
            comboBox.DataSource = dataSource;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
        }

    }

}
