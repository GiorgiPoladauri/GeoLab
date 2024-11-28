using LibraryManagementSystemProject.Models;
using Newtonsoft.Json;

namespace LibraryManagementSystemProject.Repositories
{
    public class UserRepository
    {
        private string _filePath;

        public UserRepository(string filePath)
        {
            _filePath = filePath;
        }

        public List<User> GetAll()
        {
            if (File.Exists(_filePath))
            {
                var json = File.ReadAllText(_filePath);
                return JsonConvert.DeserializeObject<List<User>>(json) ?? new List<User>();
            }
            return new List<User>();
        }

        public void Add(User user)
        {
            var users = GetAll();
            users.Add(user);
            SaveAll(users);
        }

        public void Delete(int userId)
        {
            var users = GetAll();
            var userToDelete = users.FirstOrDefault(u => u.UserId == userId);
            if (userToDelete != null)
            {
                users.Remove(userToDelete);
                SaveAll(users);
            }
        }

        public void SaveAll(List<User> users)
        {
            var json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }
    }
}
