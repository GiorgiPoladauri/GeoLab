using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using LibraryManagementProj.Core.Interfaces.IRepositories;
using LibraryManagementProj.Core.Models;
using LibraryManagementProj.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementProj.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly LibraryContext _context;

        public UserRepository(LibraryContext context)
        {
            _context = context;
        }

        public async Task<User> GetUserByIDAsync(int userid, CancellationToken cancellationToken = default)
        {
            return await _context.Users.FindAsync(new object[] { userid }, cancellationToken);
        }

        public async Task<List<User>> GetUsersByNameAsync(string username, CancellationToken cancellationToken = default)
        {
            return await _context.Users
                .Where(u => u.UserName.Contains(username))
                .ToListAsync(cancellationToken);
        }

        public async Task AddUserAsync(User user, CancellationToken cancellationToken = default)
        {
            await _context.Users.AddAsync(user, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteUserAsync(int userid, CancellationToken cancellationToken = default)
        {
            var user = await GetUserByIDAsync(userid, cancellationToken);
            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync(cancellationToken);
            }
        }

        public async Task UpdateUserAsync(User user, CancellationToken cancellationToken = default)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
