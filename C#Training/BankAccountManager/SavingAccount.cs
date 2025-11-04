using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Training.BankAccountManager
{
    public class SavingAccount : IBankaccount
    {
        public SavingAccount(string numaccount, decimal balance)
        {
            NumberAccount = numaccount;
            Balance = balance;
        }
        public string NumberAccount { get; set; }
        public decimal Balance { get; set; }

        public decimal Deposite(decimal amount)
        {
            return Balance += amount;
        }
        public decimal Withraw(decimal amount)
        {
            if (amount > Balance)
            {
                return 0;
            }
            else
            {
                decimal result = Balance - amount;
                return Balance = result;
            }
        }
        public decimal GetBalance()
        {
            throw new NotImplementedException();
        }


    }
}
