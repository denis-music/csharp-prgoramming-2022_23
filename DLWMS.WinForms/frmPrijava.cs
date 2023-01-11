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

namespace DLWMS.WinForms
{
    public partial class frmPrijava : Form
    {
        public frmPrijava()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {

            var korisnickoIme = txtKorisnickoIme.Text;
            var lozinka = txtLozinka.Text;

            if (ValidanUnos())
            {
                foreach (var korisnik in InMemoryDB.Korisnici)
                {
                    if (korisnickoIme == korisnik.KorisnickoIme && lozinka == korisnik.Lozinka)
                    {
                        if (korisnik.Aktivan)
                        {
                            MessageBox.Show($"{Resursi.Get(Kljucevi.DobroDosli)} {korisnik}",
                                Resursi.Get(Kljucevi.Informacija),
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            DLWMSApp.Korisnik = korisnik;

                            this.Hide();

                            var glavna = new frmGlavna();
                            if (glavna.ShowDialog() == DialogResult.OK)//Odjava
                                this.Show();
                            else
                                this.Close();


                        }
                        else
                            MessageBox.Show($"{korisnik}, {Resursi.Get(Kljucevi.NalogNijeAktivan)}",
                                Resursi.Get(Kljucevi.Informacija),
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        //{korisnik}, Vaš korisnički nalog nije aktivan
                        //MessageBox.Show( string.Format(Resursi.Get(Kljucevi.NalogNijeAktivan),korisnik));
                        return;
                    }
                }
                MessageBox.Show($"{Resursi.Get(Kljucevi.PodaciNisuValidni)}");
            }
        }

        private bool ValidanUnos()
        {
            return Validator.ValidirajKontrolu(txtKorisnickoIme, err, Kljucevi.ObaveznaVrijednost) &&
             Validator.ValidirajKontrolu(txtLozinka, err, Kljucevi.ObaveznaVrijednost);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmRegistracija().Show();
        }
    }

}
