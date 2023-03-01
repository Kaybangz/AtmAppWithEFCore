using System;

namespace AtmApp.DOMAIN.Exceptions
{
    [Serializable]
    public class InvalidFormatTypeException: Exception
    {
        public InvalidFormatTypeException()
        {

        }

        public InvalidFormatTypeException(string name): base(String.Format("This format is not allowed for names", name))
        {

        }

        public InvalidFormatTypeException(long number): base(String.Format("This format is not allowed for mobile number: {0}", number))
        {

        }
    }
}
