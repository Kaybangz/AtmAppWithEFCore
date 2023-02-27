using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmApp.DOMAIN.Interface
{
    public interface IAtmService
    {
        void CreateAccount();
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
        void Transfer(int Id, decimal amount);
        void ViewAccountDetails(int Id);
    }
}
