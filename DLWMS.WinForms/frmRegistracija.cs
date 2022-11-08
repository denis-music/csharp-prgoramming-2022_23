using DLWMS.Data;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinForms
{
    public partial class frmRegistracija : Form
    {
        public frmRegistracija()
        {
            InitializeComponent();
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            if (ValdanUnos())
            {
                var noviKorisnik = new Korisnik()
                {
                    Id = InMemoryDB.Korisnici.Count + 1,
                    Aktivan = cbAktivan.Checked,
                    Email = txtEmail.Text,
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text,
                    KorisnickoIme = txtKorisnickoIme.Text,
                    Lozinka = txtLozinka.Text
                };
                InMemoryDB.Korisnici.Add(noviKorisnik);
            }
        }

        private bool ValdanUnos()
        {
            return Validator.ValidirajKontrolu(txtIme, err, Kljucevi.ObaveznaVrijednost)
                && Validator.ValidirajKontrolu(txtPrezime, err, Kljucevi.ObaveznaVrijednost);
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            GenerisiPodatke();
        }

        private void GenerisiPodatke()
        {
            var podaci = $"{txtIme.Text}.{txtPrezime.Text}".ToLower();
            txtKorisnickoIme.Text = podaci;
            txtEmail.Text = $"{podaci}@edu.fit.ba";
        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            GenerisiPodatke();
        }

        private void frmRegistracija_Load(object sender, EventArgs e)
        {
            UcitajNovuLozinku();
        }


        private void UcitajNovuLozinku(int brojKaraktera = 10)
        {
            txtLozinka.Text = GenerisiLozinku(brojKaraktera);
        }

        private string GenerisiLozinku(int brojZnakova = 10)
        {
            var generisanaLozinka = "";
            var karakteri = "qwertzuiopšđžasdfghjklčćyxcvbnm,.-1234567890'+ASDFGHJKLČĆQWERTZUIOPŠĐŽ";
            var rand = new Random();
            for (int i = 0; i < brojZnakova; i++)
            {
                var lokacija = rand.Next(0, karakteri.Length);//0 - 60 -- 2
                generisanaLozinka += karakteri[lokacija];
            }
            return generisanaLozinka;
        }

        private void btnGenerisiLozinku_Click(object sender, EventArgs e)
        {
            UcitajNovuLozinku(15);
        }
    }
}
