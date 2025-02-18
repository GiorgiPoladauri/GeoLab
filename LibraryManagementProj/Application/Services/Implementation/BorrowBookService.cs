using System;
using System.Threading.Tasks;
using LibraryManagementProj.Core.Models;
using LibraryManagementProj.Core.Interfaces.IRepositories;
using LibraryManagementProj.Application.Services.Abstractions;

namespace LibraryManagementProj.Application.Services.Implementation
{
    public class BorrowBookService : IBorrowBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IBorrowedBookRepository _borrowedBookRepository;

        public BorrowBookService(IBookRepository bookRepository, IBorrowedBookRepository borrowedBookRepository)
        {
            _bookRepository = bookRepository;
            _borrowedBookRepository = borrowedBookRepository;
        }

        public async Task BorrowBookAsync(int bookid, int userid)
        {
            // Retrieve the book
            var book = await _bookRepository.GetBookByIDAsync(bookid);
            if (book == null)
                throw new Exception("Book not found.");

            // Check availability (always subtract 1 copy)
            if (book.Quantity < 1)
                throw new Exception("No copies available to borrow.");

            // Deduct one copy
            book.Quantity -= 1;
            await _bookRepository.UpdateBookAsync(book);

            // Create a borrowing record for this user
            var borrowedbook = new BorrowedBook(userid, bookid, DateTime.Now, DateTime.MinValue);
            await _borrowedBookRepository.BorrowBookAsync(borrowedbook);
        }

        public async Task ReturnBookAsync(int bookid, int userid)
        {
            // Retrieve the book
            var book = await _bookRepository.GetBookByIDAsync(bookid);
            if (book == null)
                throw new Exception("Book not found.");

            // Increase the available quantity by 1
            book.Quantity += 1;
            await _bookRepository.UpdateBookAsync(book);

            // Retrieve the borrowing record (you need to implement this method in your repository)
            var borrowedBook = await _borrowedBookRepository.GetBorrowedBookIDByBorrowerAndBookID(bookid, userid);
            if (borrowedBook == null)
                throw new Exception("Borrow record not found.");

            // Mark as returned (e.g., update the return date)
            borrowedBook.ReturnBook(DateTime.Now);
            await _borrowedBookRepository.BorrowBookAsync(borrowedBook);
        }
    }
}
