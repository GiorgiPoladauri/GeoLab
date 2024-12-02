using System;
using System.Collections.Generic;
using System.Linq;
using LibraryManagementSystemProject.Models;
using LibraryManagementSystemProject.Repositories;

namespace LibraryManagementSystemProject.Services
{
    public class BookService
    {
        private readonly BookRepository _bookRepository;

        public BookService()
        {
            _bookRepository = new BookRepository("books.json");
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _bookRepository.GetAllBooks();
        }

        public void AddBook(Book book)
        {
            if (string.IsNullOrWhiteSpace(book.Title))
                throw new Exception("Book title cannot be empty.");
            if (book.Quantity < 0)
                throw new Exception("Book quantity cannot be negative.");
            _bookRepository.AddBook(book);
        }

        public void DeleteBook(int bookId)
        {
            var books = _bookRepository.GetAllBooks();
            if (!books.Any(b => b.BookId == bookId))
                throw new Exception("Book not found.");
            _bookRepository.DeleteBook(bookId);
        }

    }
}
