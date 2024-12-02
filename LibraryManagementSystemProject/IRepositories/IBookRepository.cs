using System.Collections.Generic;
using LibraryManagementSystemProject.Models;

namespace LibraryManagementSystemProject.IRepositories
{
    public interface IBookRepository
    {
        List<Book> GetAllBooks();
        void AddBook(Book book);
        void DeleteBook(int id);
    }
}
