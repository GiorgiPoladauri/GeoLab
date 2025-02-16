using LibraryManagementProj.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementProj.Data.IRepositories
{
    public interface IBorrowedBookRepository
    {
        Task<BorrowedBook> GetBorrowedBookIDByBorrowerAndBookID(int bookid, int userid, CancellationToken CancellationToken = default);
        Task BorrowBookAsync(BorrowedBook borrowedbook, CancellationToken CancellationToken = default);

        Task ReturnBookAsync(int id, CancellationToken CancellationToken = default);
    }
}
