using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Librarian : User
    {
        public int EmployeeNumber { get; set; } 
        public Librarian(string name) 
        {
            Name = name;
        }
         
        public void AddBook(Book nwBook, Library library)
        {
            library.AddBook(nwBook);
        }
        public void RemoveBook(Book deleteBook, Library library)
        {
            library.RemoveBook(deleteBook);
        }
    }
}
