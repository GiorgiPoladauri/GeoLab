using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementProj.Core.Services.Abstractions
{
    public interface IBorrowBookService
    {
        Task BorrowBookAsync(int bookid, int userid);
        Task ReturnBookAsync(int bookid, int userid);
    }
}
