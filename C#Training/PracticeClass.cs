using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Training
{
    public class PracticeClass
    {
        //public class Program
        //{
        //    public static void Main(String[] args)
        //    {
        //        List<double> weeklytemp = GetWeekleyTemperature();
        //        Console.WriteLine($"The avrage of this week is {CalculateAvarageOfTemp(weeklytemp)}");
        //    }

        //    public static List<double> GetWeekleyTemperature()
        //    {
        //        List<double> temperature = new List<double>();
        //        string[] days = new string[7] { "Saturday", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
        //        for (int i = 0; i < days.Length; i++)
        //        {
        //            Console.WriteLine($"Please enter the temperatures of {days[i]}   (Celsius)");
        //            if (double.TryParse(Console.ReadLine(), out double temp))
        //            {
        //                temperature.Add(temp);
        //            }
        //            else
        //            {
        //                Console.WriteLine("Please enter a number");
        //            }
        //        }
        //        return temperature;

        //    }
        //    public static double CalculateAvarageOfTemp(List<double> temp)
        //    {
        //        double sum = 0;
        //        foreach(double t in temp)
        //        {
        //            sum += t;
        //        }
        //        if(temp.Count== 0)
        //        {
        //            return 0;
        //        }
        //        return sum / temp.Count;
        //    }
        //}



        //OOP Practice

        //using System.Diagnostics;

        //public class Program
        //{
        //    public static void Main(string[] args)
        //    {
        //        //PDFBook pdf = new PDFBook();
        //        //pdf.Title = "Animal Farm";
        //        //pdf.Author = "Gorge Orvel";
        //        //pdf.Price = 10.65;

        //        Book book1 = new Book("The Plague", "Albert Camus");
        //        book1.PrintBookInfo();

        //        PDFBook pdf = new PDFBook("Animal Farm", "Gorge Orvel", 16.48);
        //        pdf.PrintBookInfo();
        //    }
        //    public class Book
        //    {
        //        public Book(string title, string author)
        //        {
        //            Title = title;
        //            Author = author;
        //        }

        //        protected string Title { get; set; }
        //        protected string Author { get; set; }

        //        public virtual void PrintBookInfo()
        //        {
        //            Console.WriteLine($"{Title} {Author}");
        //        }
        //    }

        //    public class PDFBook : Book
        //    {
        //        public PDFBook(string title, string author, double price) : base(title, author)
        //        {
        //            Title = title;
        //            Author = author;
        //            Price = price;
        //        }
        //        public double Price { get; set; }

        //        //Polymorphism(OverLoading)
        //        public void PrintBookInfo(double price)
        //        {
        //            Console.WriteLine($"{Title} {Author} {price} $");
        //        }

        //        //Polymorphism(OverRiding)
        //        public override void PrintBookInfo()
        //        {
        //            Console.WriteLine($"{Title} {Price}");
        //        }
        //    }
        //}





        //Practice(Product Manager)

        //using System.Collections.Generic;
        //using System.Security.Cryptography.X509Certificates;
        //using static Program;

        //public class Program
        //{
        //    public static void Main(string[] args)
        //    {
        //        string[] ProductName = new string[] { "Keybord", "Mouse", "Laptop" };
        //        List<Product> Inventory = InitializeInventory(ProductName);
        //    }


        //    public static List<Product> InitializeInventory(string[] Proarray)
        //    {
        //        List<Product> invertorylist = new List<Product>();
        //        foreach (string p in Proarray)
        //        {
        //            Product pro = new Product(p, 1200000, 84);
        //            invertorylist.Add(pro);
        //        }
        //        return invertorylist;
        //    }


        //    public static void GenerateReport(List<Product> inv)
        //    {
        //        double total = 0;
        //        Console.WriteLine("Details of all products!");
        //        foreach (Product pro in inv)
        //        {
        //            pro.DispalyDetails();
        //        }

        //        //CalculateTotalprice
        //        for (int i = 0; i < inv.Count; i++)
        //        {
        //            total += inv[1].Price * inv[i].StockQuantity;
        //        }
        //        Console.WriteLine("Total Inventory value");
        //        Console.WriteLine($"{total:N0} Toman");
        //    }

        //    public class Product
        //    {
        //        public Product(string proname, double price, int stackquantity)
        //        {
        //            ProName = proname;
        //            Price = price;
        //            StockQuantity = stackquantity;
        //        }
        //        public string ProName { get; set; }
        //        public double Price { get; set; }
        //        public int StockQuantity { get; set; }

        //        public void DispalyDetails()
        //        {
        //            Console.WriteLine($"{ProName} {Price} {StockQuantity}");
        //            Console.ReadKey();
        //        }
        //    }
        //}
    }
}
