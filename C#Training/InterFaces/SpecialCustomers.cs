using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Training.InterFaces
{
    public class SpecialCustomers : IBaseCustomers
    {
        public string UpdateAddress(string address)
        {
            if (address == null)
            {
                return null;
            }
            else
            {
                string newaddress = address;
                return newaddress;
            }
        }

        public double UpdateCredit(double? credit)
        {
            if ((credit ?? 0.0) <= 0)
            {
                return 0;
            }
            else
            {
                double discount = credit.Value * 0.5;
                double res = credit.Value - discount;
                return res;
            }
            
        }
    }
}
