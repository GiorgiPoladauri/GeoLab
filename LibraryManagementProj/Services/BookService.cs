using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using LibraryManagementProj.Models;
using LibraryManagementProj.Services.Abstractions;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryManagementProj.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void AddBook(string bookname, string? description, DateTime publicationdate, string authorname, int pages, int quantity)
        {
            if (string.IsNullOrWhiteSpace(bookname))
                throw new Exception("Book title cannot be empty.");
            if (quantity < 0)
                throw new Exception("Book quantity cannot be negative.");
            var book = new Book(bookname, description, publicationdate, authorname, pages, quantity);
            _bookRepository.AddBook(book);
        }

        public void DeleteBook(int bookId)
        {
            if (!books.Any(b => b.BookId == bookId))
                throw new Exception("Book not found.");
            _bookRepository.DeleteBook(bookId);
        }

        public void UpdateBook(int bookid, string bookname, string? description, DateTime publicationdate, string authorname, int pages, int quantity)
        {
            _bookRepository.UpdateBook(bookid, bookname, description, publicationdate, authorname, pages, quantity);
        }
    }
}
