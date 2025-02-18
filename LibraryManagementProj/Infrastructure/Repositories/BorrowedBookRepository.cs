using LibraryManagementProj.Core.Interfaces.IRepositories;
using LibraryManagementProj.Core.Models;
using LibraryManagementProj.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace LibraryManagementProj.Infrastructure.Repositories
{
    public class BorrowedBookRepository : IBorrowedBookRepository
    {
        private readonly LibraryContext _context;

        public BorrowedBookRepository(LibraryContext context)
        {
            _context = context;
        }

        public async Task<BorrowedBook> GetBorrowedBookIDByBorrowerAndBookID(int bookid, int userid, CancellationToken cancellationToken = default)
        {
            return await _context.BorrowedBooks
                .FirstOrDefaultAsync(bb => bb.BookID == bookid && bb.UserID == userid, cancellationToken);
        }

        public async Task BorrowBookAsync(BorrowedBook borrowedbook, CancellationToken cancellationToken = default)
        {
            await _context.BorrowedBooks.AddAsync(borrowedbook, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task ReturnBookAsync(int id, CancellationToken cancellationToken = default)
        {
            var borrowedBook = await _context.BorrowedBooks.FindAsync(new object[] { id }, cancellationToken);
            if (borrowedBook != null)
            {
                borrowedBook.ReturnBook(DateTime.Now);

                _context.BorrowedBooks.Update(borrowedBook);
                await _context.SaveChangesAsync(cancellationToken);
            }
        }
    }
}
