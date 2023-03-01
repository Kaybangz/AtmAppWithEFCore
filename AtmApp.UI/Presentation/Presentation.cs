using AtmApp.DATA.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System;
using AtmApp.DATA.Entities;
using AtmApp.DOMAIN.Utils;
using AtmApp.DOMAIN;
using AtmApp.DOMAIN.Exceptions;

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
                    Console.WriteLine("Choose a pin for your account*: ");
                    int pin = int.Parse(Console.ReadLine());

                    Console.WriteLine("Confirm pin: ");
                    int confirmPin = int.Parse(Console.ReadLine());


                    if (pin != confirmPin)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nBoth pins do not match!\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }


                    Console.WriteLine("Enter your first name*: ");
                    string firstname = Console.ReadLine();

                    ValidateName.ValidateInput(firstname);


                    Console.WriteLine("Enter your middle name: ");
                    string middlename = Console.ReadLine();


                    Console.WriteLine("Enter your last name*: ");
                    string lastname = Console.ReadLine();

                    ValidateName.ValidateInput(lastname);


                    Console.WriteLine("Enter mobile number*:");
                    long phonenumber = Convert.ToInt32(Console.ReadLine());

                    ValidateNumber.ValidateInput(phonenumber.ToString());

       
                    AccountTypeLabel:
                    Console.WriteLine("Select account type: ");
                    Console.WriteLine("Press 1 for Savings || Press 2 for Current");

                    int accountTypeSelect = int.Parse(Console.ReadLine());

                    AccountType accountType;


                    if (accountTypeSelect == 1) accountType = AccountType.Savings;
                    else if (accountTypeSelect == 2) accountType = AccountType.Current;
                    else 
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nInvalid input...\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        goto AccountTypeLabel;
                    }


                    Console.WriteLine();

                    Customer customer = new Customer
                    {
                        Firstname = firstname,
                        Middlename = middlename,
                        Lastname = lastname,
                        PhoneNumber = phonenumber.ToString(),
                        Pin = pin,
                        AccountNumber = RandomNumberGenerator.Generate(10),
                        AccountType = accountType,
                        Balance = 0,
                    };

                    AtmService atm = new AtmService();
                    atm.CreateAccount(customer);

                    success = true;
                }
                while(success == false);
            }
            catch(FormatException ex)
            {
                Console.WriteLine($"Incorrect format || Error message: {ex.Message}");
            }
            catch(InvalidFormatTypeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
