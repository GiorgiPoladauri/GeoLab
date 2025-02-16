using System;
using System.Threading.Tasks;

namespace LibraryManagementProj.Core.Services.Abstractions
{
    public interface IBookService
    {
        Task AddBookAsync(string bookname, string description, DateTime publicationdate, string authorname, int pages, int quantity);
        Task DeleteBookAsync(int bookid);
        Task UpdateBookAsync(int bookid, string bookname, string description, DateTime publicationdate, string authorname, int pages, int quantity);
    }
}
