using ProductInventoryManagement.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventoryManagement
{
    public class Electronic : IProduct
    {
        public Electronic(string name, string brand, double price)
        {
            Name = name;
            Brand = brand;
            Price = price;
        }
        public string Brand { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public bool IsAvalable { get; set; }
        public double Price { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"The Product Name:{Name},it's Brand is{Brand} and it's Price about {Price}");
        }
    }
}
