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
    public partial class frmGlavna : Form
    {
        public frmGlavna()
        {
            InitializeComponent();
        }

        private void studentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var studentiPretraga = new Studenti.frmStudentiPretraga();
            studentiPretraga.MdiParent = this;
            studentiPretraga.Show();
        }

        private void krajRadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
