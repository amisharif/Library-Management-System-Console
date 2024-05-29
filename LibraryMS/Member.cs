using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System_Console.LibraryMS
{
    public class Member
    {
        public int MemberID { get; set; }
        public string Name { get; set; }
        public List<Book> BorrowedBooks { get; set; }

        public Member(int memberId, string name)
        {
            MemberID = memberId;
            Name = name;
            BorrowedBooks = new List<Book>();
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"MemberID: {MemberID}, Name: {Name}, Borrowed Books: {BorrowedBooks.Count}");
        }
    }

}
