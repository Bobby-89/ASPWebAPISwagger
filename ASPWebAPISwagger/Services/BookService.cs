using ASPWebAPISwagger.Data;
using ASPWebAPISwagger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPWebAPISwagger.Services
{
    public class BookService : IBookService
    {
        private ApplicationDbContext db { get; set; }
        public BookService(ApplicationDbContext db)
        {
            this.db = db;
        }
        public void AddBook(Book book)
        {
            this.db.Books.Add(book);
            this.db.SaveChanges();
        }

        public ICollection<Book> AllBooks()
        {
            return this.db.Books.ToList();
        }

        public void DeleteBook(int id)
        {
            Book book = this.db.Books.FirstOrDefault(x => x.Id == id);
            this.db.Remove(book);
            this.db.SaveChanges();
        }

        public void EditBook(Book book)
        {
            Book bookToEdit = this.db.Books.FirstOrDefault(x => x.Id == book.Id);
            bookToEdit.Name = book.Name;
            bookToEdit.Year = book.Year;
            this.db.SaveChanges();
        }

        public Book GetBookById(int id)
        {
            return this.db.Books.FirstOrDefault(b => b.Id == id);
        }
    }
}
