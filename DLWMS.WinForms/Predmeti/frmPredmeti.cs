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

namespace DLWMS.WinForms.Predmeti
{
    public partial class frmPredmeti : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        public frmPredmeti()
        {
            InitializeComponent();
        }

        private void frmPredmeti_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
        }

        private void UcitajPodatke()
        {
            dgvPredmeti.DataSource = null;
            dgvPredmeti.DataSource = db.Predmeti.ToList();                
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            var noviPredmet = new Predmet()
            {
                Naziv = txtNazivPredmeta.Text
            };
            db.Predmeti.Add(noviPredmet);
            db.SaveChanges();
            UcitajPodatke();
        }
    }
}
