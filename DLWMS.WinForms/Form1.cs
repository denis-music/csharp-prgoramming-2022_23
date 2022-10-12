using DLWMS.Data;

namespace DLWMS.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Konekcija konekcija = new Konekcija();
            List<Student> studenti = konekcija.GetStudentiByGodinaStudija(1);
            foreach (var student in studenti)
            {
                MessageBox.Show(student.ToString());              
            }

        }
    }
}