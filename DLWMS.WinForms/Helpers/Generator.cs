namespace DLWMS.WinForms.Helpers
{
    public class Generator
    {
        public static string GenerisiLozinku(int brojZnakova = 10)
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
    }
}
