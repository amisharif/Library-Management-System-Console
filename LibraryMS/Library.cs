using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System_Console.LibraryMS
{
    public class Library
    {
        private List<Book> books;
        private List<Member> members;
        private List<BorrowTransaction> transactions;
        private Book book;
        private Member member;  

        public Library()
        {
            books = new List<Book>();
            members = new List<Member>();
            transactions = new List<BorrowTransaction>();
           
        }

        public void AddBook()
        {
            Console.WriteLine("Enter ISBN");
            string isbn = Console.ReadLine();
            Console.WriteLine("Enter Author Name");
            string BookAuthor = Console.ReadLine();
            Console.WriteLine("Enter Book Title");
            string BookTitle = Console.ReadLine();

           
            book = new Book(isbn,BookTitle,BookAuthor);
            books.Add(book);
            
            Console.WriteLine("Book added successfully.");
        }

        public void AddMember()
        {
            Console.WriteLine("Enter Member ID");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Member Name");
            string MemberName = Console.ReadLine();

            member = new Member(id, MemberName);


            members.Add(member);
            Console.WriteLine("Member added successfully.");
        }

        public void BorrowBook()
        {

            Console.WriteLine("Give below information for borrow a book");
            Console.WriteLine("Enter member ID");
            int memberId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter ISBN");
            string isbn = Console.ReadLine();

            var member = members.FirstOrDefault(m => m.MemberID == memberId);
            var book = books.FirstOrDefault(b => b.ISBN == isbn && b.IsAvailable);

            if (member != null && book != null)
            {
                book.IsAvailable = false;
                member.BorrowedBooks.Add(book);
                var transaction = new BorrowTransaction(member, book, DateTime.Now);
                transactions.Add(transaction);
                Console.WriteLine("Book borrowed successfully.");
            }
            else
            {
                Console.WriteLine("Book is not available or Member not found.");
            }
        }

        public void ReturnBook()
        {
            Console.WriteLine("Give below information for return a book");
            Console.WriteLine("Enter member ID");
            int memberId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter ISBN");
            string isbn = Console.ReadLine();

            var member = members.FirstOrDefault(m => m.MemberID == memberId);
            var book = member?.BorrowedBooks.FirstOrDefault(b => b.ISBN == isbn);

            if (member != null && book != null)
            {
                book.IsAvailable = true;
                member.BorrowedBooks.Remove(book);
                Console.WriteLine("Book returned successfully.");
            }
            else
            {
                Console.WriteLine("Book or Member not found.");
            }
        }

        public void DisplayAllBooks()
        {
            foreach (var book in books)
            {
                book.DisplayDetails();
            }
        }

        public void DisplayAllMembers()
        {
            foreach (var member in members)
            {
                member.DisplayDetails();
            }
        }
    }

}
