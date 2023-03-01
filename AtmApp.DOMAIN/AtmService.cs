using AtmApp.DATA;
using AtmApp.DATA.Entities;
using AtmApp.DOMAIN.Interface;
using AtmApp.DOMAIN.Utils;
using Microsoft.EntityFrameworkCore;
using System;


namespace AtmApp.DOMAIN
{
    public class AtmService : IAtmService
    {
        private AtmDbContext _dbContext { get; set; } = DbContextClass.GetDbContext();
        public void CreateAccount(Customer customer)
        {
            try
            {
                _dbContext.Customers.Add(customer);

                var msg = _dbContext.SaveChanges() > 0 ? "Your account has been created successfully" : "Account creation failed";

                
                Console.WriteLine("\n************************************");
                Console.WriteLine($"|{msg}|");
                Console.WriteLine("************************************\n");
            }
            catch
            {
                throw new Exception("Something went wrong...");
            }
        }

        public void Deposit(decimal amount)
        {
            throw new NotImplementedException();
        }

        public void Transfer(int Id, decimal amount)
        {
            throw new NotImplementedException();
        }

        public void ViewAccountDetails(int Id)
        {
            throw new NotImplementedException();
        }

        public void Withdraw(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
