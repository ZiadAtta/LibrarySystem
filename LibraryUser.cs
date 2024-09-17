using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class LibraryUser : User
    {
        public LibraryCard Card { get; set; }

        // public Book[] DisplayBooks()
        // {

        // }

        public LibraryUser(string name)
        {
            Name = name;
        }
        public void BorrowBook(Book book , Library library)
        {
            library.BorrowBook(book);
        }
    }
}
