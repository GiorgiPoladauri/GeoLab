using System;
using System.Threading.Tasks;
using LibraryManagementProj.Core.Models;
using LibraryManagementProj.Infrastructure.Data;
using LibraryManagementProj.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace LibraryManagementProj.Test.Infrastructure.Repositories
{
    public class BookRepositoryxUnitTest
    {
        private DbContextOptions<LibraryContext> CreateNewContextOptions()
        {
            return new DbContextOptionsBuilder<LibraryContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
        }

        [Fact]
        public async Task AddBookAsync_ShouldAddBookToDatabase()
        {
            var options = CreateNewContextOptions();
            using var context = new LibraryContext(options);
            var repository = new BookRepository(context);

            var testBook = new Book(
                bookname: "Test Book",
                description: "This is a test book.",
                publicationdate: DateTime.UtcNow,
                authorname: "Test Author",
                pages: 123,
                quantity: 10);

            int newBookId = await repository.AddBookAsync(testBook);
            var retrievedBook = await repository.GetBookByIDAsync(newBookId);

            Assert.NotNull(retrievedBook);
            Assert.Equal("Test Book", retrievedBook.BookName);
            Assert.Equal("This is a test book.", retrievedBook.Description);
            Assert.Equal("Test Author", retrievedBook.AuthorName);
            Assert.Equal(123, retrievedBook.Pages);
            Assert.Equal(10, retrievedBook.Quantity);
        }
    }
}
