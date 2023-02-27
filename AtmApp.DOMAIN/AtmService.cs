using AtmApp.DOMAIN.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmApp.DOMAIN
{
    public class AtmService : IAtmService
    {
        public void CreateAccount()
        {
            throw new NotImplementedException();
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
