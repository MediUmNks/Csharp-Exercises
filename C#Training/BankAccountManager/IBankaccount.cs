using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Training.BankAccountManager
{
    public interface IBankaccount
    {
        decimal Deposite(decimal amount);
        decimal Withraw(decimal amount);
        decimal GetBalance();
    }
}
