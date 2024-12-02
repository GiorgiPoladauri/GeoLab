using LibraryManagementSystemProject.IRepositories;
using LibraryManagementSystemProject.Models;
using Newtonsoft.Json;

namespace LibraryManagementSystemProject.Repositories
{
    public class BorrowedBookRepository : IBorrowedBookRepository
    {
        private string _filePath;

        public BorrowedBookRepository(string filePath)
        {
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataFiles");

            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            _filePath = Path.Combine(folderPath, "borrowedbooks.json");

            if (!File.Exists(_filePath))
                File.WriteAllText(_filePath, "[]");
        }

        public List<BorrowedBook> GetAllBorrowedBooks()
        {
            if (File.Exists(_filePath))
            {
                var json = File.ReadAllText(_filePath);
                return JsonConvert.DeserializeObject<List<BorrowedBook>>(json) ?? new List<BorrowedBook>();
            }
            return new List<BorrowedBook>();
        }

        public void BorrowBook(BorrowedBook borrowedBook)
        {
            var borrowedBooks = GetAllBorrowedBooks();
            borrowedBooks.Add(borrowedBook);
            SaveAll(borrowedBooks);
        }

        public void ReturnBook(int borrowedBookId)
        {
            var borrowedBooks = GetAllBorrowedBooks();
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
