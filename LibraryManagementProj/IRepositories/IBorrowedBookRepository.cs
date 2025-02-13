using LibraryManagementProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementProj.IRepositories
{
    public interface IBorrowedBookRepository
    {
        List<BorrowedBook> GetBorrowedBooksByName(string Name);
        Task BorrowBook(int id);
        Task ReturnBook(int id);
    }
}
