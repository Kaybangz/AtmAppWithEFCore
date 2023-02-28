using AtmApp.DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmApp.UI.Presentation
{
    public class Presentation
    {
        public void CreateAccount()
        {
            try
            {
                bool success = false;

                do
                {
                    Console.WriteLine("Enter your full name: ");
                    string fullname = Console.ReadLine();

                    Console.WriteLine("Choose a pin: ");
                    int pin = int.Parse(Console.ReadLine());

                    Console.WriteLine("Confirm pin: ");
                    int confirmPin = int.Parse(Console.ReadLine());

                    if(pin != confirmPin)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nBoth pins do not match!\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }

                    Console.WriteLine("Select account type: ");
                    Console.WriteLine("Press 1 for Savings || Press 2 for Current");

                    int accountTypeSelect = int.Parse(Console.ReadLine());

                    AccountType accountType;

                    if (accountTypeSelect == 1) accountType = AccountType.Savings;
                    else if (accountTypeSelect == 2) accountType = AccountType.Current;
                    else 
                    {
                        Console.WriteLine("\nInvalid input...\n");
                        break;
                    } 






                    success = true;
                }
                while(success == false);
            }
            catch(Exception ex)
            {
                if (ex is FormatException) throw new FormatException($"Incorrect format || Error message: {ex.Message}");
                if (ex is NullReferenceException) throw new NullReferenceException($"Cannot have null values || Error message: {ex.Message}");
            }
        }
    }
}
