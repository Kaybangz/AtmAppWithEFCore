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
        void Withdraw(int amount);
        void Transfer();
        void ViewAccountDetails();
    }
}
