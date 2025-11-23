using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace C_Training.BookLibraryManagment
{
    public class Book : ILibraryItem
    {
        public Book(string bookname, string author, int publicationyear)
        {
            Bookname = bookname;
            Author = author;
            PublicationYear = publicationyear;
        }
        public string Bookname { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
        public bool IsBorrowed { get; set; }

        public static void Borrow()
        {
            Console.WriteLine("Which one of our book wana to Borrow?");
            string borrow = Console.ReadLine()!;
            Console.WriteLine($"the {borrow} Borrowed successfuly");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"The name of book is {Bookname} it's Author is{Author}, its PublicationYear is {PublicationYear} and the Borroweded status of this book is {IsBorrowed}");
        }

        public void Return()
        {
            Console.WriteLine($"The {Bookname} is returned to library");
        }
    }
}
