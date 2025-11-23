using ProductInventoryManagement.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventoryManagement
{
    public class Book : IProduct
    {
        public Book(string name, string author, int publishmentYear, double price)
        {
            Name = name;
            Author = author;
            PublishmentYear = publishmentYear;
            Price = price;
        }
        public string Author { get; set; }
        public int PublishmentYear { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public bool IsAvalable { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"The Book's Name is {Name} ,writtered by {Author} in {PublishmentYear} and the price of author's thinking is {Price}");
        }
    }
}

