using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System_Console.LibraryMS
{
    public class BorrowTransaction
    {
        public Member Member { get; set; }
        public Book Book { get; set; }
        public DateTime BorrowDate { get; set; }

        public BorrowTransaction(Member member, Book book, DateTime borrowDate)
        {
            Member = member;
            Book = book;
            BorrowDate = borrowDate;
        }
    }

}
