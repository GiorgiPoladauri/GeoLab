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
    public class UserRepositoryxUnitTest
    {
        private LibraryContext CreateInMemoryDatabase()
        {
            var options = new DbContextOptionsBuilder<LibraryContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            return new LibraryContext(options);
        }

        [Fact]
        public async Task AddUserAsync_ShouldAddUserSuccessfully()
        {
            using var context = CreateInMemoryDatabase();
            var userRepository = new UserRepository(context);
            var userService = new UserService(userRepository);

            string username = "Test Username";
            string personalNumber = "01111111111";
            string email = "Test@mail.com";
            await userService.AddUserAsync(username, personalNumber, email);

            var createdUser = await context.Users.FirstOrDefaultAsync(u => u.PersonalNumber == personalNumber);

            Assert.NotNull(createdUser);
            Assert.Equal(username, createdUser.UserName);
            Assert.Equal(personalNumber, createdUser.PersonalNumber);
            Assert.Equal(email, createdUser.Email);
        }
    }
}
