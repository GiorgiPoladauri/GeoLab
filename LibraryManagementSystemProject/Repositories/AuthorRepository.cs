using LibraryManagementSystemProject.IRepositories;
using LibraryManagementSystemProject.Models;
using Newtonsoft.Json;

namespace LibraryManagementSystemProject.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private string _filePath;

        public AuthorRepository(string filePath)
        {
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataFiles");

            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            _filePath = Path.Combine(folderPath, "Authors.json");

            if (!File.Exists(_filePath))
                File.WriteAllText(_filePath, "[]");
        }

        public List<Author> GetAllAuthors()
        {
            if (File.Exists(_filePath))
            {
                var json = File.ReadAllText(_filePath);
                return JsonConvert.DeserializeObject<List<Author>>(json) ?? new List<Author>();
            }
            return new List<Author>();
        }

        public void AddAuthor(Author author)
        {
            var authors = GetAllAuthors();
            authors.Add(author);
            SaveAllAuthor(authors);
        }

        public void DeleteAuthor(Author author)
        {
            var authors = GetAllAuthors();
            authors.Delete(author);
            DeleteAuthor(author);
        }

        public void SaveAllAuthor(List<Author> authors)
        {
            var json = JsonConvert.SerializeObject(authors, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }
    }
}
