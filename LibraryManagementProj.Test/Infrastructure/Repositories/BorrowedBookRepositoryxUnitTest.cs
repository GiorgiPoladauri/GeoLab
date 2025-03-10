using System;
using System.Threading.Tasks;
using LibraryManagementProj.Application.Services.Implementation;
using LibraryManagementProj.Core.Models;
using LibraryManagementProj.Infrastructure.Data;
using LibraryManagementProj.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace LibraryManagementProj.Test.Infrastructure.Repositories
{
    public class BorrowBookServiceTests
    {
        private LibraryContext CreateInMemoryDatabase()
        {
            var options = new DbContextOptionsBuilder<LibraryContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString()) 
                .Options;

            return new LibraryContext(options);
        }

        [Fact]
        public async Task BorrowBookAsync_ShouldBorrowBookSuccessfully()
        {
            using var context = CreateInMemoryDatabase();
            var bookRepository = new BookRepository(context);
            var borrowedBookRepository = new BorrowedBookRepository(context);
            var borrowBookService = new BorrowBookService(bookRepository, borrowedBookRepository);

            var book = new Book("Test Book", "Description", DateTime.Now, "Author", 100, 5);
            await context.Books.AddAsync(book);
            await context.SaveChangesAsync();

            int bookId = book.BookID;
            int userId = 1;

            await borrowBookService.BorrowBookAsync(bookId, userId);

            var borrowedBook = await context.BorrowedBooks.FirstOrDefaultAsync(bb => bb.BookID == bookId && bb.UserID == userId);
            var updatedBook = await context.Books.FindAsync(bookId);

            Assert.NotNull(borrowedBook);
            Assert.Equal(4, updatedBook.Quantity);
        }
    }
}
