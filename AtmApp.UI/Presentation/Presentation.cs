using AtmApp.DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System;
using AtmApp.DATA.Entities;
using AtmApp.DOMAIN.Utils;
using AtmApp.DOMAIN;

namespace AtmApp.UI.Presentation
{
    public class PresentationClass
    {

        public AtmService atmService { get; set; } = new AtmService();
        public static void CreateAccount()
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

                    Console.WriteLine();

                    Console.WriteLine("Confirm pin: ");
                    int confirmPin = int.Parse(Console.ReadLine());

                   

                    if (pin != confirmPin)
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


                    Console.WriteLine();

                    //Customer customer = new Customer
                    //{
                    //    Name = fullname,
                    //    Pin = pin,
                    //    AccountNumber = RandomNumberGenerator.Generate(10),
                    //    AccountType = accountType,
                    //    Balance = 0,
                    //};

                    //AtmService atm = new AtmService();
                    //atm.CreateAccount(customer);

                    success = true;
                }
                while(success == false);
            }
            catch(Exception ex)
            {
                if (ex is FormatException) Console.WriteLine($"Incorrect format || Error message: {ex.Message}");
                //7386551865
            }
        }
    }
}
