using Library_Management_System_Console.LibraryMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System_Console
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Library library = new Library();

            // Adding Books
           
            library.AddBook();
            library.AddBook();

            // Adding Members
            library.AddMember();
            library.AddMember();


            // Display All Books
            library.DisplayAllBooks();
            // Display All Members
            library.DisplayAllMembers();

            // Borrow a Book
            library.BorrowBook();

            // Display All Books after borrowing
            library.DisplayAllBooks();

            // Return a Book
            library.ReturnBook();

            // Display All Books after returning
            library.DisplayAllBooks();

            // Display All Members after transactions
            library.DisplayAllMembers();


            Console.ReadKey();
        }
    }
}
