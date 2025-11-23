using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Training.BookLibraryManagment
{
    public interface ILibraryItem
    {
        public string Bookname { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; set; }
        public bool IsBorrowed { get; set; }

        void Return();
        void DisplayInfo();
    }
}
