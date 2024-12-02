using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using LibraryManagementSystemProject.Models;
using LibraryManagementSystemProject.IRepositories;

namespace LibraryManagementSystemProject.Repositories
{
    public class BookRepository : IBookRepository
    {
        private string _filePath;

        public BookRepository(string filePath)
        {
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataFiles");

            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            _filePath = Path.Combine(folderPath, "books.json");

            if (!File.Exists(_filePath))
                File.WriteAllText(_filePath, "[]");
        }

        public List<Book> GetAllBooks()
        {
            if (File.Exists(_filePath))
            {
                var json = File.ReadAllText(_filePath);
                return JsonConvert.DeserializeObject<List<Book>>(json) ?? new List<Book>();
            }
            return new List<Book>();
        }

        public void AddBook(Book book)
        {
            var books = GetAllBooks();
            books.Add(book);
            SaveAllBooks(books);
        }

        public void DeleteBook(int id)
        {
            var books = GetAllBooks();
            var bookToDelete = books.FirstOrDefault(b => b.BookId == id);
            if (bookToDelete != null)
            {
                books.Remove(bookToDelete);
                SaveAllBooks(books);
            }
        }

        private void SaveAllBooks(List<Book> books)
        {
            var json = JsonConvert.SerializeObject(books, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }
    }
}
