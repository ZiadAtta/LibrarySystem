using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public abstract class User
    {
        public int Id { get; set; }
        public string Name{ get; set; }

        public void DisplayBooks(Library library)
        {
            library.DisplayBook();
        }
    }    
}
 