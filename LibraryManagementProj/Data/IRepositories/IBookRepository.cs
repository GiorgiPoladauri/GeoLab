using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using LibraryManagementProj.Core.Models;

namespace LibraryManagementProj.Data.IRepositories
{
    public interface IBookRepository
    {
        Task<Book> GetBookByIDAsync(int id, CancellationToken CancellationToken = default);
        Task<List<Book>> GetBooksByNameAsync(string name, CancellationToken CancellationToken = default);
        Task<int> AddBookAsync(Book book, CancellationToken CancellationToken = default);
        Task DeleteBookAsync(int id, CancellationToken CancellationToken = default);
        Task UpdateBookAsync(Book book, CancellationToken CancellationToken = default);
    }
}
