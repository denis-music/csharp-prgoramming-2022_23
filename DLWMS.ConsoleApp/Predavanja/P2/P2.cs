using DLWMS.Data;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.ConsoleApp.Predavanja.P2
{
      
    public class MainP2
    {
        public static void Pokreni()
        {
            //VrijednostiReference();
            //Nizovi();
            //PodrazumijevaneVrijednosti();
            //ProvjeraNullVrijednosti();
            //SlanjeParametara();
            //Imutabilnost();
            //Dekonstrukcija();
            //Params();
            //Indekseri();
        }

        private static void Indekseri()
        {
            var obj = new Student()
            {
                GodinaStudija = 1,
                MentorId = null,
                Prezime = "Prezime"
            };
            Console.WriteLine($"obj[0] = {obj[0]}");
            obj[0] = 6;
            Console.WriteLine($"obj[0] = {obj[0]}");
        }

        private static void Params()
        {
            int suma1 = Sumiraj(new int[] { 2, 35, 8, 6 });
            int suma2 = Sumiraj(2, 35, 8, 6, 12);

            var tekst1 = string.Join("*", 2, 35, 8, 6, 12, 6565, 654);
            var tekst2 = string.Join(" - ", "denis","fit", "mostar");
        }

        private static int Sumiraj(params int [] niz)
        {
            var suma = 0;
            for (int i = 0; i < niz.Length; i++)
                suma += niz[i];
            return suma;
        }

        private static int Sumiraj2(params int[] niz)
        {
            return niz.Sum();            
        }

        private static int Sumiraj3(params int[] niz) =>  niz.Sum();
        
        private static void Dekonstrukcija()
        {
            var obj = new Student()
            {
                GodinaStudija = 1,
                MentorId = null,
                Prezime = "Prezime"
            };

           // Student denis = new();
            //var ime = "Denis";
            //var aktivan = true;
            //var cijena = 3.4;

            //string prezime; 
            //int godinaStudija;
            //obj.Deconstruct(out prezime, out godinaStudija);

            var (vPrezime, vGodinaStudija) = obj;//obj.Deconstruct(out vPrezime, out vGodinaStudija)


        }

        private static void Imutabilnost()
        {
            string ime = "Denis";
            ime = ime.ToUpper();
            Console.WriteLine(ime);//DENIS

            DateTime danas = DateTime.Now;
            danas = danas.AddDays(2);
            Console.WriteLine(danas.ToString("dd.MM.yyyy"));

        }

        private static void SlanjeParametara()
        {
            Student student = null ;
            InicijalizujStudenta(in student);
            Console.WriteLine(student.Prezime);

            int rezultat;
            if(int.TryParse("65d4", out rezultat))
                Console.WriteLine(rezultat);
        }

        private static void InicijalizujStudenta(in Student obj)
        {
            //obj = new Student()
            //{
            //    GodinaStudija = 1,
            //    MentorId = null,
            //    Prezime = "Prezime"
            //};
            obj.GodinaStudija = 2;
        }

        private static void ProvjeraNullVrijednosti()
        {
            Konekcija konekcija = new Konekcija();
            Student student = konekcija.GetStudentByIndeks("IB210012");
            //uslov ? ispunjen : nije_ispunjen
            string prezime = student?.Prezime ?? "PREZIME";

            Console.WriteLine(prezime);
        }

        private static void PodrazumijevaneVrijednosti()
        {
            int a = new int();
            int b = 0;

            int ? test = null;
            Nullable<int> test2 = null;
            test = 20;
            if(test.HasValue)
                Console.WriteLine(test.Value);


            Student marko = new Student() { Prezime= "Nišić", MentorId = null};
            marko = null;
        }

        private static void Nizovi()
        {

            DLStudent[] dlStudenti = new DLStudent[3];
            for (int i = 0; i < dlStudenti.Length; i++)
            {
                dlStudenti[i].Prezime = $"Prezime{i}";
                dlStudenti[i].GodinaStudija = i + 1;
            }
            Student[] studenti = new Student[3];
            for (int i = 0; i < studenti.Length; i++)
            {
                studenti[i] = new Student();
                studenti[i].Prezime = $"Prezime{i}";
                studenti[i].GodinaStudija = i + 1;
            }
        }

        private static void VrijednostiReference()
        {
            int a = new int();
            int b = a;

            b = 20;

            Student   student1   = new Student()   { Prezime = "Music", GodinaStudija = 1 };
            DLStudent dlStudent1 = new DLStudent() { Prezime = "Music", GodinaStudija = 1 };
            
            Student student2 = student1;
            Console.WriteLine(student1);
            Console.WriteLine(student2);
            student2.Prezime = "Modifikacija prezimena";
            Console.WriteLine(student1);
            Console.WriteLine(student2);

            Console.WriteLine("-----------------------------");


            DLStudent dlStudent2 = dlStudent1;
            Console.WriteLine(dlStudent1);
            Console.WriteLine(dlStudent2);
            dlStudent2.Prezime = "Novo prezime";
            Console.WriteLine(dlStudent1);
            Console.WriteLine(dlStudent2);



        }

    }
}
