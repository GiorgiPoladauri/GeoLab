using LibraryManagementProj.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementProj.Core.Interfaces.IRepositories
{
    public interface IUserRepository
    {
        Task<User> GetUserByIDAsync(int userid, CancellationToken CancellationToken = default);
        Task<List<User>> GetUsersByNameAsync(string username, CancellationToken CancellationToken = default);
        Task AddUserAsync(User user, CancellationToken CancellationToken = default);
        Task DeleteUserAsync(int userid, CancellationToken CancellationToken = default);
        Task UpdateUserAsync(User user, CancellationToken CancellationToken = default);
    }
}
