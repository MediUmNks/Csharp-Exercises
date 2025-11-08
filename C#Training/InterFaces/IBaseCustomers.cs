using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Training.InterFaces
{
    public interface IBaseCustomers
    {
        string UpdateAddress(string address);
        double UpdateCredit(double? credit);
    }
}
