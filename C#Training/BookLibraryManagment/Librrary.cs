using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Training.BookLibraryManagment
{
    public class Librrary
    {
        List<ILibraryItem> libraryItems = new List<ILibraryItem>();
        public void AddBook()
        {
            Console.WriteLine("How many book do you wana to add?");
            int bookcount = int.Parse(Console.ReadLine()!);
            for (int i = 0; i < bookcount; i++)
            {
                Console.WriteLine($"What is the Name of book?");
                string bookname = Console.ReadLine()!;
                Console.WriteLine($"Who is the Author of this book?");
                string author = Console.ReadLine()!;
                Console.WriteLine($"when was this book Published?");
                int publication = int.Parse(Console.ReadLine()!);
                Book book1 = new Book(bookname, author, publication);
                libraryItems.Add(book1);
            }
        }

        public void RemoveItem(string bookname)
        {
            foreach (var item in libraryItems)
            {
                if (item.Bookname == bookname)
                {
                    item.Bookname.Remove(0);
                }
                else
                {
                    Console.WriteLine("This Book is not exist in librarty");
                }
            }
        }

        public void DisplayAllItem()
        {
            foreach (var item in libraryItems)
            {
                Console.WriteLine(item);
            }

        }
    }
}
