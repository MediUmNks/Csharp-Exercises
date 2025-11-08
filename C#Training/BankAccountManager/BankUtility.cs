using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Training.BankAccountManager
{
    public static class BankUtility
    {
        public static void PrintTransActionSummary(IBankaccount bankaccount)
        {
            if (bankaccount is SavingAccount sa)
            {
                Console.WriteLine($"The account number: {sa.NumberAccount} and the amount of balance: {sa.Balance}");
            }
        }
    }
}
