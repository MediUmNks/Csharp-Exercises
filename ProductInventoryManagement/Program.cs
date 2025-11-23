using ProductInventoryManagement.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInventoryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu for Manage by User");
            Console.WriteLine("------------------------");
            Console.WriteLine("Pleasr press only number 1-4 for using this managment console progarm!!");

            List<IProduct> products = new List<IProduct>();


            bool exist = true;

            while (exist)
            {
                Console.WriteLine("1_ Insert Product!!");
                Console.WriteLine("2_ Show All Product!!");
                Console.WriteLine("3_ Searching Product");
                Console.WriteLine("4_ Exist!!");
                int res = Convert.ToInt32(Console.ReadLine());

                switch (res)
                {
                    case 1:
                        Console.WriteLine("What is kind of Product do you want to add? Book or Electronic?");
                        string reskind = Console.ReadLine().ToUpper().Trim();
                        if (reskind == "BOOK")
                        {
                            Console.WriteLine("How many book do you want to add?");
                            int numberofbook = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < numberofbook; i++)
                            {
                                Console.WriteLine("What is your bookname?");
                                string bookname = Console.ReadLine();
                                Console.WriteLine("Who is that Author?");
                                string author = Console.ReadLine();
                                Console.WriteLine("How much is this book?");
                                double bookprice = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("When was this book Published? (it must be number of year!!!)");
                                int publishedbook = Convert.ToInt32(Console.ReadLine());
                                Book newbook = new Book(bookname, author, publishedbook, bookprice);
                                products.Add(newbook);

                                Console.WriteLine("This book add successfully!!");
                            }
                        }
                        else if (reskind == "ELECTRONIC")
                        {
                            Console.WriteLine("How many Electronic product do you want to add?");
                            int numberofelectronicalproduct = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < numberofelectronicalproduct; i++)
                            {
                                Console.WriteLine("What is your Electronic product name?");
                                string elcname = Console.ReadLine();
                                Console.WriteLine("What is it's Brand");
                                string brand = Console.ReadLine();
                                Console.WriteLine("How much is it's Price?");
                                double elcprice = Convert.ToDouble(Console.ReadLine());
                                Electronic electrinic = new Electronic(elcname, brand, elcprice);
                                products.Add(electrinic);

                                Console.WriteLine("Electronic product add successfully!!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Your product must be book or electrinical product!!");
                        }
                        break;
                    case 2:

                        Console.WriteLine("Which Product do you want to have their list?");
                        var r = Console.ReadLine().ToUpper().Trim();
                        if (r == "BOOK" || r == "BOOKS")
                        {
                            foreach (var item in products)
                            {
                                if (item is Book book)
                                {
                                    Console.WriteLine($"The Book's Name is {book.Name} ,writtered by {book.Author} in {book.PublishmentYear} and the price of author's thinking is {book.Price}");
                                }
                            }
                        }
                        if (r == "Electronic")
                        {
                            foreach (var item in products)
                            {
                                if (item is Electronic elc)
                                {
                                    Console.WriteLine($"The Product Name:{elc.Name},it's Brand is{elc.Brand} and it's Price about {elc.Price}");
                                }
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("What do you want to Search? for more Expensive Products insert Exp, for sorting product insert sort and for get avarege price of all product insert avg: ");
                        string search = Console.ReadLine().ToUpper().Trim();
                        if (products.Count == 0)
                        {
                            Console.WriteLine("Inventory is empty. Please add products first.");
                            break;
                        }
                        if (search == "EXP")
                        {
                            Console.WriteLine("What is your range for sorting by price?");
                            double sortrange = Convert.ToDouble(Console.ReadLine());
                            var exp = products.Where(x => x.Price > sortrange).ToList();
                            foreach (var item in exp)
                            {
                                item.DisplayInfo();
                            }

                        }
                        else if (search == "SORT")
                        {
                            var srt = products.OrderBy(x => x.Name).ToList();
                            foreach (var item in srt)
                            {
                                item.DisplayInfo();
                            }
                        }
                        else if (search == "AVG")
                        {
                            var avg = products.Average(x => x.Price);
                            Console.WriteLine($"\nThe average price of all products is: {avg:C}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid Search Commond");
                        }
                        break;
                }
            }
        }
    }
}
