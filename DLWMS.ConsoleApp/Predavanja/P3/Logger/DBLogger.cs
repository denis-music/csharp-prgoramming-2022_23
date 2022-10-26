namespace DLWMS.ConsoleApp.Predavanja.P3
{
    public class DBLogger : ILogger
    {
        private const string Putanja = "Server = 192.168.1.10; DataBase = DLWMS";
        public void Log(object message)
        {
            Console.WriteLine($"DBLog -> {Putanja}\nData -> {DataExtractor.GetData(message)}");
        }
    }
}
