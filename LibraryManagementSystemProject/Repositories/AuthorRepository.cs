using LibraryManagementSystemProject.Models;
using Newtonsoft.Json;

namespace LibraryManagementSystemProject.Repositories
{
    public class AuthorRepository
    {
        private string _filePath;

        public AuthorRepository(string filePath)
        {
            _filePath = filePath;
        }

        public List<Author> GetAll()
        {
            if (File.Exists(_filePath))
            {
                var json = File.ReadAllText(_filePath);
                return JsonConvert.DeserializeObject<List<Author>>(json) ?? new List<Author>();
            }
            return new List<Author>();
        }

        public void Add(Author author)
        {
            var authors = GetAll();
            authors.Add(author);
            SaveAll(authors);
        }

        public void SaveAll(List<Author> authors)
        {
            var json = JsonConvert.SerializeObject(authors, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }
    }
}
