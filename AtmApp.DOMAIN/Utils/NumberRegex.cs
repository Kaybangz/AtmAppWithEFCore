using AtmApp.DOMAIN.Exceptions;
using System.Text.RegularExpressions;

namespace AtmApp.DOMAIN.Utils
{
    public class ValidateNumber
    {
        public static void ValidateInput(string input)
        {
            Regex regex = new Regex("^[0-9]*$");

            if (!regex.IsMatch(input))
                throw new InvalidFormatTypeException(input);
        }
    }
}
