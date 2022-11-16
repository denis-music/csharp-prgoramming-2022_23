using DLWMS.Data;
using DLWMS.WinForms.Helpers;

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


        public frmStudentiNovi(Student odabraniStudent = null)
        {
            InitializeComponent();
            student = odabraniStudent ?? new Student();
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
                student.Slika = pbSlikaStudenta.Image;
                student.Lozinka = txtLozinka.Text;


                var poruka = Kljucevi.PodaciUspjesnoModifikovani;

                if (student.Id == 0)
                {
                    student.Id = InMemoryDB.Studenti.Count + 1;
                    poruka = Kljucevi.PodaciUspjesnoDodati;
                    InMemoryDB.Studenti.Add(student);
                }

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
            if (student.Id == 0)
                NoviStudent();
            else
                UcitajPodatkeOStudentu();
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
            pbSlikaStudenta.Image = student.Slika;
            txtLozinka.Text = student.Lozinka;
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
            txtBrojIndeksa.Text = $"IB{(DateTime.Now.Year - 2000) * 10000 + InMemoryDB.Studenti.Count + 1}";
        }

        private void GenerisiPodatke()
        {
            txtEmail.Text = $"{txtIme.Text}.{txtPrezime.Text}@edu.fit.ba".ToLower();
        }


        private void UcitajGodineStudija()
        {
            cmbGodinaStudija.DataSource = InMemoryDB.GodineStudija;
            cmbGodinaStudija.DisplayMember = "Oznaka";
            cmbGodinaStudija.ValueMember = "Id";

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
    }
}
