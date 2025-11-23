using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Training.AbstractClasses
{
    public abstract class Transaction
    {
        // Abstract classes are similar to interfaces but there are many differences between them;
        // 1. The first difference is that in abstract class we can use implementation methods and not implementation;
        // 2. Second we should use Abstract because it is a key to use it in other classes;

        public void AlarmUser()
        {
            Console.WriteLine("Not Allowed");
        }

        public abstract void UpdateCredite(double credit);
        public abstract string UpdateAddres(string address);
    }
}
