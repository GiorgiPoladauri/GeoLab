using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementProj.Application.Services.Abstractions
{
    public interface IUserService
    {
        Task AddUserAsync(string username, string personalnumber, string email);
        Task DeleteUserAsync(int userid);
        Task UpdateUserAsync(int userid, string username, string personalnumber, string email);
    }
}
