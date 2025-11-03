using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Training.AbstractClasses
{
    public class NormalUser : Transaction
    {
        // Use override is very important for impleamenting abstracting methodes;
        public override string UpdateAddres(string address)
        {
            string newstring = address;
            return newstring;

        }

        public override void UpdateCredite(double credit)
        {
            if (credit > 0)
            {
                double discount = credit * 0.2;
                double result = credit - discount;
                if (result > 500000)
                {
                    // Using a method implemented in the abstract class
                    AlarmUser();
                }
                else
                {
                    Console.WriteLine($"{result}Paying was successfylu");
                }
            }

        }
    }
}
