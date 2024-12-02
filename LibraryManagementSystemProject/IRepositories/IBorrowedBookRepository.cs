using LibraryManagementSystemProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemProject.IRepositories
{
    public interface IBorrowedBookRepository
    {
        List<BorrowedBook> GetAllBorrowedBooks();
        void BorrowBook(int id);
        void ReturnBook(int id);
    }
}
