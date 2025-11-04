using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Training.StaticClasses
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string name = MyStaticClass.Name;
            string lastname = MyStaticClass.lastname;
            MyStaticClass.FullName(name,lastname);
        }
    }
    public class MyStaticClass
    {
        // In static classes, our variables and methods must be static and we cannot create any objects from static classes;
        public static string Name { get; set; } = "Mahdi";
        public static string lastname { get; set; } = "Nakhei";
        public static void FullName(string name, string lastname)
        {
            Console.WriteLine(name + " " + lastname);
        }
    }
}
