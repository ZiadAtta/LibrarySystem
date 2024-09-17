using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class Library
    {
        public int Id { get; set; }
         public string Name { get; set; } 
         private List<Book> Books=  new List<Book>();


        private List<Book> BorrowedBooks = new List<Book>();

        public Library(string name)
        {
            Name = name;
        }
        public void DisplayBook()
        {
            foreach (var book in Books)
            {
                    Console.WriteLine(book.Title);
            }
        }

        public void DisplayBorrowBooks()
        {
            foreach (var book in BorrowedBooks)
            {
                Console.WriteLine(book.Title);
            }
        }

        public void AddBook(Book book)
        {
            if (Books.Count() < 100)
            {
                Books.Add(book);
                Console.WriteLine("The book Added successfully");
            }
            else
            { 
                Console.WriteLine("Library is full , can't add new books");
                Console.WriteLine("If you want to remove book enter (Remove) else enter (NO)");

                string choice = Console.ReadLine();

                if(choice == "Remove")
                { 
                    Console.WriteLine("Enter book details Name ,Author and the Year");
                    string bookName = Console.ReadLine();
                    string bookAuthor = Console.ReadLine();
                    int bookYear = Convert.ToInt32(Console.ReadLine());
                    Book deleteBook = new Book()
                    {
                        Title = bookName,
                        Author = bookAuthor,
                        Year = bookYear
                    };

                    if (RemoveBook(deleteBook))
                    {
                        Books.Add(book);
                    }

                }

            }
        }

        public bool RemoveBook(Book book)
        {
            if (Books.Count==0)
            {
                Console.WriteLine("The library is Empty");
                return false;
            }
            else if(Books.Contains(book)) 
            {
                Books.Remove(book);
                Console.WriteLine("The book is removed ");
                return true;
            }
            else
            {
                Console.WriteLine($"this book {book.Title} is not in the library");
                return false;
            }
        }

        public void BorrowBook (Book book)
        {
            if( BorrowedBooks.Count()>=50)
            {
                Console.WriteLine("You can't borrow , Sorry we reach to the maximum borrow (Sorry Again ^_^) ");
            }
            else
            {
                BorrowedBooks.Add(book);
                Books.Remove(book);
                Console.WriteLine("the book is borrowed successfully");
            }
        }
        public void GetBackBook(Book book)
        {
            if (BorrowedBooks.Contains(book))
            {
                BorrowedBooks.Remove(book);
                Books.Add(book);

                Console.WriteLine($"We get to the book {book.Title} to the Library {Name} successfully ");
            }
            else
            {
                Console.WriteLine($"This library {Name} don't Contain this book {book.Title}");
            }
        }
    }
}
