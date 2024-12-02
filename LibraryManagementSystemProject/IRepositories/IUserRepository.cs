using LibraryManagementSystemProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemProject.IRepositories
{
    public interface IUserRepository
    {
        List<Book> GetAllUsers();
        void AddUser(User user);
        void DeleteUser(int id);
    }
}
