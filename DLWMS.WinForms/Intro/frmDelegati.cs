using System.Collections;

namespace DLWMS.WinForms.Intro
{

    /*
     
    
    
    
    = Saberi;

    cout << fPok(10) << endl;
    fPok = Kvadriraj;
    cout << fPok(10) << endl << endl;


    int (*matOperacije[3])(int); // EVENT
     
     */

    public partial class frmDelegati : Form
    {

        //DELEGAT :: PRAVILO :: IZGLED METODE
        //int (* fPok) (int);
        //fPok = Saberi;

        

        delegate void PotpisMetode(string poruka);

        event PotpisMetode DLWMSNotifikacije;

     
        public frmDelegati()
        {
            InitializeComponent();

            //Izracunaj += Saberi;
            //Izracunaj += Kvadriraj;
            //Izracunaj += Kubiraj;
        }

        private void btnNotifikacije_Click(object sender, EventArgs e)
        {
            //DLWMSNotifikacije(txtPoruka.Text);
            //DLWMSNotifikacije?.Invoke(txtPoruka.Text);

            //txtPoruka.Text += $" Calc(Saberi,2,6,9,8) => {Calc(Saberi, 2, 6, 9, 8)}" + Environment.NewLine;
            //txtPoruka.Text += $" Calc(Kvadriraj,2,6,9,8) => {Calc(Kvadriraj, 2, 6, 9, 8)}" + Environment.NewLine;
            //txtPoruka.Text += $" Calc(Kubiraj,2,6,9,8) => {Calc(Kubiraj, 2, 6, 9, 8)}" + Environment.NewLine;

            //Func<int, int> func = Saberi;
            //Func<int, float, string, int> func1 = Test;           

            YieldDemo();
        }
        int Test(int a, float b, string c) { return 0; }
        int Saberi(int broj) { return broj + broj; }
        int Kvadriraj(int broj) { return broj * broj; }
        int Kubiraj(int broj) { return broj * broj * broj; }

        delegate int MatMetoda(int broj);

        event MatMetoda Izracunaj;
        private int Calc(Func<int, int> metoda, params int [] niz)
        {
            int suma = 0;
            for (int i = 0; i < niz.Length; i++)
                suma += metoda(niz[i]);
            return suma;
        }


        private void PrvaGodina(string poruka)
        {
            MessageBox.Show($"PRVA GODINA -> {poruka}");
        }
        private void DrugaGodina(string poruka)
        {
            MessageBox.Show($"DRUGA GODINA -> {poruka}");
        }
        private void TrecaGodina(string poruka)
        {
            MessageBox.Show($"TRECA GODINA -> {poruka}");
        }

        private void cbPrvaGodina_CheckedChanged(object sender, EventArgs e)
        {
            PretplataNaDogadjaj(sender, PrvaGodina);
        }

        private void PretplataNaDogadjaj(object sender, PotpisMetode metoda)
        {
            if ((sender as CheckBox).Checked)
                DLWMSNotifikacije += metoda;
            else
                DLWMSNotifikacije -= metoda;
        }


        private void cbDrugaGodina_CheckedChanged(object sender, EventArgs e)
        {
            PretplataNaDogadjaj(sender, DrugaGodina);
        }

        private void cbTrecaGodina_CheckedChanged(object sender, EventArgs e)
        {
            PretplataNaDogadjaj(sender, TrecaGodina);
        }

        private void YieldDemo()
        {
            Kandidat kandidat = new Kandidat();
            foreach (var ocjena in kandidat)
            {

            }
        }
    }
    public class Kandidat
    {
        List<int> ocjene = new List<int>() { 4, 5, 4, 3, 5, 5, 4, 3 };

        public IEnumerator GetEnumerator()
        {
            //for (int i = 0; i < ocjene.Count; i++)
            //  yield return ocjene[i];//return ocjene[0]
            yield return ocjene[0];
            yield return ocjene[1];
            yield return ocjene[2];
            yield return ocjene[3];
            yield return ocjene[4];

        }
    }

}
