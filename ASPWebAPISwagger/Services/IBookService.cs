using ASPWebAPISwagger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPWebAPISwagger.Services
{
    interface IBookService
    {
        void AddBook(Book book);

        Book GetBookById(int id);
        ICollection<Book> AllBooks();

        void EditBook(Book book);

        void DeleteBook(int id);
    }
}
