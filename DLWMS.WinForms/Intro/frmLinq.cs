using DLWMS.Data;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace DLWMS.WinForms.Intro
{
    public partial class frmLinq : Form
    {
        public frmLinq()
        {
            InitializeComponent();

            //TipoviPodataka();
            //AnonimniTipovi();
            DodateMetode();
            Linq();

        }

        private void Linq()
        {
            /*
            FROM Products
            WHERE Price > 50             
            SELECT * --ProductName, Price 
             */

            var ocjene = new List<int>() { 6, 6, 7, 8, 7, 9, 6, 8 };

            var rezOcjene = from o in ocjene
                           where o > 7
                           select o;

            var godineStudija = new List<GodinaStudija>() {
                    new GodinaStudija()  { Id = 1, Aktivna = true, Oznaka= "1 - GODINA", Opis = "Prva godina studija"  },
                    new GodinaStudija()  { Id = 2, Aktivna = false, Oznaka= "2 - GODINA", Opis = "Druga godina studija"  },
                    new GodinaStudija()  { Id = 3, Aktivna = false, Oznaka= "3 - GODINA", Opis = "Treca godina studija"  },
                    new GodinaStudija()  { Id = 4, Aktivna = true, Oznaka= "4 - GODINA", Opis = "Cetvrta godina studija"  }
            };

            var rezGodine = from godina in godineStudija
                            where godina.Aktivna == true
                            select new
                            {
                                Rb = godina.Id,
                                Ispis = godina.Oznaka,
                            };

            var rezGodine2 = godineStudija.Where(FiltrirajGodine2);

            var rezGodine3 = godineStudija.Where(godina => godina.Aktivna == true);

        }

        private bool FiltrirajGodine2(GodinaStudija godina) => godina.Aktivna == true;
        

        private bool FiltrirajGodine1(GodinaStudija godina)
        {
            return godina.Aktivna == true;
        }

        private void AnonimniTipovi()
        {
            var obj = new { id = 1, indeks = 150051, ime = "Denis" };

            var tuple = (id: 1, indeks: 150051, ime: "Denis", nekiString: "");
            tuple.id = 2;
            tuple.indeks = 150052;

            TupleInfo(new dtoStudent() { Id = 1, Indeks = 150051, Ime = "Denis", KrvnaGrupa = "O+" });
        }

        private dtoStudent TupleInfo(dtoStudent obj)
        {
            return obj;
        }

        private void TipoviPodataka()
        {
            object ime;
            ime = "Denis";
            object indeks = 150051;
            object ocjene = new List<int>();

            var prezime = "Music";
            //string prezime = "Music";

            PrikaziInfo(ime);

            dynamic student = "Denis Music";
            student = 150051;
            student = new List<int>() { 6, 6, 7, 8, 7, 9, 6, 8 };

            //dynamic obj = GetEksterniObjekat();

            dynamic objExp = new ExpandoObject();
            //objExp.Add(Ime, "Denis");
            //objExp.Add(Indeks, 150051);
            objExp.Ime = "Denis";
            objExp.Indeks = 150051;
            objExp.Ocjene = new List<int>() { 6, 6, 7, 8, 7, 9, 6, 8 };
            //IDictionary<string, object?>

            foreach (var osobine in objExp)
            {
                MessageBox.Show(osobine.ToString());
            }

            //Dictionary<int, string> studenti = new Dictionary<int, string>();
            //studenti.Add(150051, "Denis Music");
            //studenti.Add(150052, "Jasmin Azemovic");


            //StudentInfo(objExp);
            //Potvrde(obj);
        }

        private void StudentInfo(dynamic objExp)
        {
            MessageBox.Show($"{objExp.Ime} {objExp.Indeks}");
        }

        private void Potvrde(dynamic obj)
        {
            obj.Printaj();
        }

        private dynamic GetEksterniObjekat()
        {
            return new Eksterni();
        }

        private void PrikaziInfo(object obj)
        {
            //Osoba * pok = new Student(150051,"Denis Music"...);
            //pok -> 
            //obj.Info();
        }

        private void DodateMetode()
        {
            var imePrezime = "Denis Music";
            var enkript = imePrezime.Enkriptuj();
            var dekript = enkript.Dekriptuj();

            MessageBox.Show(DateTime.Now.ToBiHFormat());
        }
    }


    public static class DodateMetode
    {

        public static void LoadData<T>(this ComboBox comboBox, List<T> dataSource,
           string displayMember = "Naziv", string valueMember = "Id")
        {
            comboBox.DataSource = dataSource;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
        }

        public static string ToBiHFormat(this DateTime obj)
        {
            return $"BIH FORMAT :) -> {obj.ToString("dd.MM.yyyy hh:mm:ss")}";
        }


        public static string uVelikaSlova(this string obj)
        {
            return obj.ToUpper();
        }
        public static string Enkriptuj(this string obj)//Denis
        {
            var enkriptovaniSadrzaj = string.Empty;//Denis
            for (int i = 0; i < obj.Length; i++)
                enkriptovaniSadrzaj += (char)(Convert.ToInt16(obj[i]) + i + 1);
            return enkriptovaniSadrzaj;
        }

        public static string Dekriptuj(this string obj)
        {
            var dekriptovaniSadrzaj = string.Empty;
            for (int i = 0; i < obj.Length; i++)
                dekriptovaniSadrzaj += (char)(Convert.ToInt16(obj[i]) - i - 1);
            return dekriptovaniSadrzaj;
        }
    }

    public class Eksterni
    {
        public void Printaj()
        {
            MessageBox.Show("Printam");
        }
    }

    public class dtoStudent
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public int Indeks { get; set; }
        public string KrvnaGrupa { get; set; }

    }
}
