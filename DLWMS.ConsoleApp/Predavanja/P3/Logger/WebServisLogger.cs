namespace DLWMS.ConsoleApp.Predavanja.P3
{
    public class WebServisLogger : ILogger
    {
        private const string Putanja = @"uri:log.fit.ba;token:321321-adsf54sd54-sdf1321sdf0";
        public void Log(object message)
        {
            Console.WriteLine($"WebServisLog -> {Putanja}\nData -> {DataExtractor.GetData(message)}");
        }
    }
}
