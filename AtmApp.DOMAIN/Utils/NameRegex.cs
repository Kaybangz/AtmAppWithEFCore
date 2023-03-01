using AtmApp.DOMAIN.Exceptions;
using System.Text.RegularExpressions;


namespace AtmApp.DOMAIN.Utils
{
    public class ValidateName
    {
        public static void ValidateInput(string input)
        {
            Regex regex = new Regex("^[a-zA-Z]+$");

            if (!regex.IsMatch(input))
                throw new InvalidFormatTypeException(input);
        }
    }
}
