using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using LibraryManagementProj.Core.Interfaces.IRepositories;
using LibraryManagementProj.Core.Models;
using LibraryManagementProj.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementProj.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryContext _context;

        public BookRepository(LibraryContext context)
        {
            _context = context;
        }

        public async Task<Book> GetBookByIDAsync(int id, CancellationToken cancellationToken = default)
        {
            return await _context.Books.FindAsync(new object[] { id }, cancellationToken);
        }

        public async Task<List<Book>> GetBooksByNameAsync(string name, CancellationToken cancellationToken = default)
        {
            return await _context.Books
                .Where(b => b.BookName.Contains(name))
                .ToListAsync(cancellationToken);
        }

        public async Task<int> AddBookAsync(Book book, CancellationToken cancellationToken = default)
        {
            await _context.Books.AddAsync(book, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return book.BookID;
        }

        public async Task DeleteBookAsync(int id, CancellationToken cancellationToken = default)
        {
            var book = await GetBookByIDAsync(id, cancellationToken);
            if (book != null)
            {
                _context.Books.Remove(book);
                await _context.SaveChangesAsync(cancellationToken);
            }
        }

        public async Task UpdateBookAsync(Book book, CancellationToken cancellationToken = default)
        {
            _context.Books.Update(book);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
