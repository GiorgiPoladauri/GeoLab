using System.Collections.Generic;
using LibraryManagementProj.Models;

namespace LibraryManagementProj
{
    public interface IBookRepository
    {
        List<Book> GetBooksByName(string Name);
        Task<int> AddBook(Book book);
        Task DeleteBook(int id);
        Task UpdateBook(Book book);
        Task GetBookByID(int id);
    }
}
