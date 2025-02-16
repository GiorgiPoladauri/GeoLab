using System;
using System.Threading.Tasks;
using LibraryManagementProj.Models;
using LibraryManagementProj.Data.IRepositories;
using LibraryManagementProj.Core.Services.Abstractions;

namespace LibraryManagementProj.Core.Services.Implementation
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task AddBookAsync(string bookname, string description, DateTime publicationdate, string authorname, int pages, int quantity)
        {
            if (string.IsNullOrWhiteSpace(bookname))
                throw new Exception("Book title cannot be empty.");
            if (quantity < 0)
                throw new Exception("Book quantity cannot be negative.");

            var book = new Book(bookname, description, publicationdate, authorname, pages, quantity);

            await _bookRepository.AddBookAsync(book);
        }

        public async Task DeleteBookAsync(int bookid)
        {
            var book = await _bookRepository.GetBookByIDAsync(bookid);
            if (book == null)
                throw new Exception("Book not found.");

            await _bookRepository.DeleteBookAsync(bookid);
        }

        public async Task UpdateBookAsync(int bookid, string bookname, string description, DateTime publicationdate, string authorname, int pages, int quantity)
        {
            var book = await _bookRepository.GetBookByIDAsync(bookid);
            if (book == null)
                throw new Exception("Book not found.");

            await _bookRepository.UpdateBookAsync(book);
        }
    }
}
