using AtmApp.UI.Presentation;

namespace AtmApp.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("===================================");
                    Console.WriteLine("===== Welcome to Genesys Bank =====");
                    Console.WriteLine("===================================");

                    Console.WriteLine("\nPress 1 => Create new account\nPress 2 => Login\nPress 3 => Quit");
                    int optionSelect = int.Parse(Console.ReadLine());

                    switch (optionSelect)
                    {
                        case 1:
                            PresentationClass.CreateAccount();
                            break;
                        case 2:
                            break;
                        case 3:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Incorrect input!");
                            break;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}