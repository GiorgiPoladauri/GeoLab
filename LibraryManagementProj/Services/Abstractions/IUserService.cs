using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementProj.Services.Abstractions
{
    public interface IUserService
    {
        Task AddUser(string username, string personalnumber, string email);
        Task DeleteUser(string username, string personalnumber, string email);
        Task UpdateUser(string username, string personalnumber, string email);
    }
}
