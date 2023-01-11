using DLWMS.WinForms.Intro;

using System;
using System.CodeDom;
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
    public partial class frmGlavna : Form
    {
        public frmGlavna()
        {
            InitializeComponent();
        }

        private void studentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var studentiPretraga = new Studenti.frmStudentiPretraga();
            //studentiPretraga.MdiParent = this;
            //studentiPretraga.Show();
        }

        private void PrikaziFormu(Form forma)
        {
            forma.MdiParent = this;
            forma.Show();
        }

        private void krajRadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void noviStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var noviStudent = new Studenti.frmStudentiNovi();
            //noviStudent.MdiParent = this;
            //noviStudent.Show();
            PrikaziFormu(new Studenti.frmStudentiNovi());

        }

        private void pretragaStudenataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new Studenti.frmStudentiPretraga());
        }

        private void xOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikaziFormu(new frmXO());
        }

        private void odjavaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void frmGlavna_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Da li ste sigurni da želite zatvoriti glavnu formu?",
                "Pitanje",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel= true;            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblPrikaziDatumVrijeme.Text = DateTime.Now.ToBiHFormat();
        }
    }
}
