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

namespace DLWMS.WinForms.Studenti
{
    public partial class frmStudentiPretraga : Form
    {
        public frmStudentiPretraga()
        {            
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void frmStudentiPretraga_Load(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void UcitajStudente(List<Student> studenti = null)
        {
            dgvStudenti.DataSource = null;
            dgvStudenti.DataSource = studenti ?? InMemoryDB.Studenti;
        }

        private void btnDodajStudenta_Click(object sender, EventArgs e)
        {
            var frmStudent = new frmStudentiNovi();
            //var rezutat = frmStudent.ShowDialog();
            if (frmStudent.ShowDialog() == DialogResult.OK)
                UcitajStudente();
        }

        private void dgvStudenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var odabraniStudent = dgvStudenti.SelectedRows[0].DataBoundItem as Student;           

            if (odabraniStudent != null)
            {
                var frmStudent = new frmStudentiNovi(odabraniStudent);
                frmStudent.ShowDialog();
                UcitajStudente();

                //var modifikujStudenta = new frmStudentiNovi();
                //modifikujStudenta.Student = odabraniStudent;
                //modifikujStudenta.ShowDialog();
            }
        }

        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            var pretraga = txtPretraga.Text.ToLower();
            var rezultat = new List<Student>();

            foreach (var student in InMemoryDB.Studenti)
            {
                if(student.Ime.ToLower().Contains(pretraga) || student.Prezime.ToLower().Contains(pretraga)
                    || student.BrojIndeksa.ToLower().Contains(pretraga))
                rezultat.Add(student);
            }
            UcitajStudente(rezultat);

    }
}
}
