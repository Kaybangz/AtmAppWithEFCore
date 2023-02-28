namespace AtmApp.DOMAIN.Utils
{
    public class RandomNumberGenerator
    {
        public static string Generate(int length)
        {
            var random = new Random();
            string number = string.Empty;
            for (int i = 0; i < length; i++)
                number = String.Concat(number, random.Next(10).ToString());
            return number;
        }
    }
}
