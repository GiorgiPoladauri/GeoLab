using LibraryManagementSystemProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemProject.IRepositories
{
    public interface IAuthorRepository
    {
        List<Author> GetAllAuthors();
        void AddAuthor(Author author);
        void DeleteAuthor(int id);
\    }
}
