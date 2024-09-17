namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the library System");

            Repeat:
            Console.WriteLine(" Ary you Librarian or regular user L/R");
            char UserType = Console.ReadLine().ToUpper()[0];

            Console.WriteLine("Enter the name of the library ");
            string nameLibrary = Console.ReadLine();
            Library library = new Library(nameLibrary);

            if (UserType == 'L')
            {
                Console.WriteLine("Enter You Name");
                String librarianName = Console.ReadLine();


                Librarian l1 = new Librarian(librarianName);

                Console.WriteLine($"Welcome {l1.Name}");
                while (true)
                {
                    Console.WriteLine("If you want to add a book enter (_A_) and if " +
                        "you want to remove enter (_R_) and if you want to dis" +
                        "play enter (_D_)");
                    char LibrarianChoice = Console.ReadLine().ToUpper()[0];

                    switch (LibrarianChoice)
                    {
                        case 'A':
                            Console.WriteLine("Enter book details Name ,Author and the Year");
                            string bookName = Console.ReadLine();
                            string bookAuthor = Console.ReadLine();
                            int bookYear = Convert.ToInt32(Console.ReadLine());
                            Book book = new Book()
                            {
                                Title = bookName,
                                Author = bookAuthor,
                                Year = bookYear
                            };
                            l1.AddBook(book, library);
                            break;
                        case 'R':
                            Console.WriteLine("Enter book details Name ,Author and the Year");
                            bookName = Console.ReadLine();
                            bookAuthor = Console.ReadLine();
                            bookYear = Convert.ToInt32(Console.ReadLine());
                            book = new Book()
                            {
                                Title = bookName,
                                Author = bookAuthor,
                                Year = bookYear
                            };
                            l1.RemoveBook(book, library);
                            break;
                        case 'D':
                            Console.WriteLine("The books in list ");
                            library.DisplayBook();
                            break;

                        default:
                            Environment.Exit(0);
                            break;

                    }
                }

            }
            else if (UserType == 'R')
            {
                Console.WriteLine("Welcome user , Enter you name");

                string libraryUserName = Console.ReadLine();


                LibraryUser u1 = new LibraryUser(libraryUserName);

                Console.WriteLine($"Welcome {libraryUserName}");

                while (true)
                {
                    Console.WriteLine("If you want to borrow a book enter (_B_) and if you want to dis" +
                        "play enter (_D_)");
                    char userChoice = Console.ReadLine().ToUpper()[0];

                    switch (userChoice)
                    {
                        case 'B':
                            Console.WriteLine("Enter book details Name ,Author and the Year");
                            string bookName = Console.ReadLine();
                            string bookAuthor = Console.ReadLine();
                            int bookYear = Convert.ToInt32(Console.ReadLine());
                            Book book = new Book()
                            {
                                Title = bookName,
                                Author = bookAuthor,
                                Year = bookYear
                            };
                            u1.BorrowBook(book, library);
                            break;
                        case 'D':
                            Console.WriteLine("The books in list ");
                            u1.DisplayBooks(library);
                            break;

                        default:
                            Environment.Exit(0);
                            break;

                    }

                }
            }
            else
            {
                //make repeat Ok...
                Console.WriteLine("Please enter Correct value (L or R)");
                goto Repeat;
            }
        }
    }
}
 