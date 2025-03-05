using System;
using System.Threading.Tasks;
using LibraryManagementProj.Application.Services.Implementation;
using LibraryManagementProj.Core.Interfaces.IRepositories;
using LibraryManagementProj.Core.Models;
using LibraryManagementProj.Infrastructure.Data;
using LibraryManagementProj.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace LibraryManagementProj.Test.Application.Services
{
    public class BorrowBookServiceTests
    {
        private LibraryContext CreateInMemoryDatabase()
        {
            var options = new DbContextOptionsBuilder<LibraryContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString()) // Unique DB for each test
                .Options;

            return new LibraryContext(options);
        }

        [Fact]
        public async Task BorrowBookAsync_ShouldBorrowBookSuccessfully()
        {
            // Arrange: Create an in-memory DB and repositories
            using var context = CreateInMemoryDatabase();
            var bookRepository = new BookRepository(context);
            var borrowedBookRepository = new BorrowedBookRepository(context);
            var borrowBookService = new BorrowBookService(bookRepository, borrowedBookRepository);

            // Add a test book
            var book = new Book("Test Book", "Description", DateTime.Now, "Author", 100, 5);
            await context.Books.AddAsync(book);
            await context.SaveChangesAsync();

            int bookId = book.BookID;
            int userId = 1;

            // Act: Borrow the book
            await borrowBookService.BorrowBookAsync(bookId, userId);

            // Assert: Check if quantity decreased and a borrow record was created
            var borrowedBook = await context.BorrowedBooks.FirstOrDefaultAsync(bb => bb.BookID == bookId && bb.UserID == userId);
            var updatedBook = await context.Books.FindAsync(bookId);

            Assert.NotNull(borrowedBook);
            Assert.Equal(4, updatedBook.Quantity); // Quantity should decrease by 1
        }

        [Fact]
        public async Task BorrowBookAsync_ShouldThrowException_WhenNoCopiesAvailable()
        {
            // Arrange
            using var context = CreateInMemoryDatabase();
            var bookRepository = new BookRepository(context);
            var borrowedBookRepository = new BorrowedBookRepository(context);
            var borrowBookService = new BorrowBookService(bookRepository, borrowedBookRepository);

            // Add a book with 0 copies
            var book = new Book("Test Book", "Description", DateTime.Now, "Author", 100, 0);
            await context.Books.AddAsync(book);
            await context.SaveChangesAsync();

            int bookId = book.BookID;
            int userId = 1;

            // Act & Assert
            var exception = await Assert.ThrowsAsync<Exception>(() => borrowBookService.BorrowBookAsync(bookId, userId));
            Assert.Equal("No copies available to borrow.", exception.Message);
        }

        [Fact]
        public async Task ReturnBookAsync_ShouldReturnBookSuccessfully()
        {
            // Arrange
            using var context = CreateInMemoryDatabase();
            var bookRepository = new BookRepository(context);
            var borrowedBookRepository = new BorrowedBookRepository(context);
            var borrowBookService = new BorrowBookService(bookRepository, borrowedBookRepository);

            // Add a book and a borrow record
            var book = new Book("Test Book", "Description", DateTime.Now, "Author", 100, 5);
            book.BookID = 0; // Let EF handle it
            await context.Books.AddAsync(book);
            await context.SaveChangesAsync();

            int bookId = book.BookID;
            int userId = 1;
            var borrowedBook = new BorrowedBook(userId, bookId, DateTime.Now, DateTime.Now.AddMonths(1));
            await context.BorrowedBooks.AddAsync(borrowedBook);
            await context.SaveChangesAsync();

            // Act: Return the book
            await borrowBookService.ReturnBookAsync(bookId, userId);

            // Assert: Check if quantity increased and return date was updated
            var updatedBook = await context.Books.FindAsync(bookId);
            var updatedBorrowedBook = await context.BorrowedBooks.FirstOrDefaultAsync(bb => bb.BookID == bookId && bb.UserID == userId);

            Assert.Equal(6, updatedBook.Quantity); // Quantity should increase by 1
            Assert.NotNull(updatedBorrowedBook);
            Assert.True(updatedBorrowedBook.ReturnDate <= DateTime.Now); // Return date should be updated
        }

        [Fact]
        public async Task ReturnBookAsync_ShouldThrowException_WhenNoBorrowRecordFound()
        {
            // Arrange
            using var context = CreateInMemoryDatabase();
            var bookRepository = new BookRepository(context);
            var borrowedBookRepository = new BorrowedBookRepository(context);
            var borrowBookService = new BorrowBookService(bookRepository, borrowedBookRepository);

            // Add a test book (but no borrow record)
            var book = new Book("Test Book", "Description", DateTime.Now, "Author", 100, 5);
            await context.Books.AddAsync(book);
            await context.SaveChangesAsync();

            int bookId = book.BookID;
            int userId = 1;

            // Act & Assert
            var exception = await Assert.ThrowsAsync<Exception>(() => borrowBookService.ReturnBookAsync(bookId, userId));
            Assert.Equal("Borrow record not found.", exception.Message);
        }
    }
}
