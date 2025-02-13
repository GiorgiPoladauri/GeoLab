using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementProj.Services.Abstractions
{
    public interface IBorrowBookService
    {
        Task BorrowBook(int bookid /*Maybe Quantity ?*/);
        Task ReturnBook(int bookid);
    }
}
