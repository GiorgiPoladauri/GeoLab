using LibraryManagementProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementProj.IRepositories
{
    public interface IUserRepository
    {
        List<Book> GetUserByName();
        Task AddUser(int id);
        Task DeleteUser(int id);
    }
}
