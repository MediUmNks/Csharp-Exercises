using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Training
{
    public class NormalCustomers : IBaseCustomers
    {
        public string UpdateAddress(string address)
        {
            //if address be null return null string to user and we dont have carshing
            return address ?? string.Empty;
        }

        public double UpdateCredit(double? credit)
        {
            if (credit <= 0)
            {
                return 0;
            }
            else
            {
                //If we use the ?? argument, the value type is converted to a nullable value type and in this situation we must use .value to access the values;
                double newcredit = credit.Value * 0.2;
                double discount = credit.Value - newcredit;
                return discount;
            }
        }
    }
}
