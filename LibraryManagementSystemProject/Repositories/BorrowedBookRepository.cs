using LibraryManagementSystemProject.Models;
using Newtonsoft.Json;

namespace LibraryManagementSystemProject.Repositories
{
    public class BorrowedBookRepository
    {
        private string _filePath;

        public BorrowedBookRepository(string filePath)
        {
            _filePath = filePath;
        }

        public List<BorrowedBook> GetAll()
        {
            if (File.Exists(_filePath))
            {
                var json = File.ReadAllText(_filePath);
                return JsonConvert.DeserializeObject<List<BorrowedBook>>(json) ?? new List<BorrowedBook>();
            }
            return new List<BorrowedBook>();
        }

        public void Add(BorrowedBook borrowedBook)
        {
            var borrowedBooks = GetAll();
            borrowedBooks.Add(borrowedBook);
            SaveAll(borrowedBooks);
        }

        public void Delete(int borrowedBookId)
        {
            var borrowedBooks = GetAll();
            var borrowedBookToDelete = borrowedBooks.FirstOrDefault(u => u.BorrowedBookId == borrowedBookId);
            if (borrowedBookToDelete != null)
            {
                borrowedBooks.Remove(borrowedBookToDelete);
                SaveAll(borrowedBooks);
            }
        }

        public void SaveAll(List<BorrowedBook> borrowedBooks)
        {
            var json = JsonConvert.SerializeObject(borrowedBooks, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }
    }
}
