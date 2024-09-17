using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public  class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }   
        public string Author { get; set; }  
        public int Year { get; set; }

        public override bool Equals(object? obj)
        {
            if(obj is Book b)
            {
                return (this.Title==b.Title&& this.Author==b.Author&&this.Year==b.Year);  
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Title, Author, Year);
        }
    }
}
