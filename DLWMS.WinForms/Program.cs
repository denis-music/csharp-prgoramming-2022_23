namespace DLWMS.WinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var startnaForma = new Asinhrono.frmPing(); //new frmGlavna(); //Studenti.frmStudentiPretraga();//new Predmeti.frmPredmeti(); 
            Application.Run(startnaForma);
        }
    }
}