namespace DLWMS.ConsoleApp.Predavanja.P3
{
    public class DataExtractor
    {
        public static string GetData(object message)
        {
            if (message == null) return string.Empty;
            if (message is Exception)
                return (message as Exception).Message;
            return message.ToString();
        }
    }
}
