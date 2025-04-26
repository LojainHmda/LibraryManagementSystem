using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryManagementSystem
{
    
        class Member : AbstractPerson
        {
            public List<Book> BorrowedBooks;

        public Member(int Id, string Name) : base(Id, Name)
        {
            BorrowedBooks = new List<Book>();
        }

        public void BorrowBook(Book book)
            {
                if (book.IsAvailable == true)
                {
                    book.IsAvailable = false;
                    BorrowedBooks.Add(book);
                Console.WriteLine($"Book \"{book.Title}\" borrowed successfully.");
            }
            else
                {
                    Console.WriteLine(" book is not Available");
                }
            }
            public void ReturnBook(Book book) {

            if (BorrowedBooks.Contains(book))
            {
                book.IsAvailable = true;
                BorrowedBooks.Remove(book);
                Console.WriteLine($"Book \"{book.Title}\" has been returned.");
            }
            else
            {
                Console.WriteLine(" book is already returned");
            }
        }
            public void DisplayBorrowedBooks() {
            BorrowedBooks.ForEach(book => { Console.WriteLine($"book ID: {book.Id},name: {book.Title}"); });
          
        }

            public override void DisplayInfo()  {
            
                Console.WriteLine($"Member ID: {this.Id},name: {this.Name}");
            
        }
        }
        public class Book
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string AuthorName { get; set; }
            public bool? IsAvailable { get; set; }

            public Book(int id, string title, string authorName, bool? isAvailable = true)
            {
                Id = id;
                Title = title;
                AuthorName = authorName;
                IsAvailable = isAvailable;
            }

            public void DisplayInfo()
            {
            Console.WriteLine($"Book ID: {this.Id}, Title: {this.Title}, Author: {this.AuthorName}, Status: {this.IsAvailable}");
        }
        }
        class Library
        {
            public List<Book> ListOfBooks;
            public List<AbstractPerson> Members;

        public Library()
        {
            ListOfBooks = new List<Book>();
            Members = new List<AbstractPerson>();
        }

        public void AddBook(Book book)
            {
                ListOfBooks.Add(book);
            }
            public void AddMember(AbstractPerson member)
            {
                Members.Add(member);
            }
            public Book FindBookById(int id)
            {
                Book book = ListOfBooks.FirstOrDefault(book => book.Id == id);
                if (book == null)
                    return null;
                         return book;
            }
            public AbstractPerson FindMemberById(int id)
            {
                AbstractPerson member = Members.FirstOrDefault(memberBook => memberBook.Id == id);
                if (member == null)
                    return null;
    

            return member;
            }
            public void DisplayAllBooks()
            {
            ListOfBooks.ForEach(book => book.DisplayInfo());
        }
        public void DisplayAllMembers()
            {
            Members.ForEach(member => member.DisplayInfo());
        }
    }
    
}
