using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementProj.Services.Abstractions
{
    public interface IBookService
    {
        Task AddBook(string bookname, string? description, DateTime publicationdate, string authorname, int pages, int quantity);
        Task DeleteBook(int BookID);
        Task UpdateBook(int bookid, string bookname, string? description, DateTime publicationdate, string authorname, int pages, int quantity);
    }
}
