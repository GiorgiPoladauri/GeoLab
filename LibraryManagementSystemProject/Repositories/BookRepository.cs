using LibraryManagementSystemProject.Models;
using Newtonsoft.Json;

namespace LibraryManagementSystemProject.Repositories
{
    public class BookRepository
    {
        private string _filePath;

        public BookRepository(string filePath)
        {
            _filePath = filePath;
        }

        public List<Book> GetAll()
        {
            if (File.Exists(_filePath))
            {
                var json = File.ReadAllText(_filePath);
                return JsonConvert.DeserializeObject<List<Book>>(json) ?? new List<Book>();
            }
            return new List<Book>();
        }

        public void Add(Book book)
        {
            var books = GetAll();
            books.Add(book);
            SaveAll(books);
        }

        public void SaveAll(List<Book> books)
        {
            var json = JsonConvert.SerializeObject(books, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }
    }
}
