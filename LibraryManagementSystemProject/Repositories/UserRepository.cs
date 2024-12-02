using LibraryManagementSystemProject.IRepositories;
using LibraryManagementSystemProject.Models;
using Newtonsoft.Json;

namespace LibraryManagementSystemProject.Repositories
{
    public class UserRepository : IUserRepository
    {
        private string _filePath;

        public UserRepository(string filePath)
        {
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataFiles");

            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            _filePath = Path.Combine(folderPath, "users.json");

            if (!File.Exists(_filePath))
                File.WriteAllText(_filePath, "[]");
        }

        public List<User> GetAllUsers()
        {
            if (File.Exists(_filePath))
            {
                var json = File.ReadAllText(_filePath);
                return JsonConvert.DeserializeObject<List<User>>(json) ?? new List<User>();
            }
            return new List<User>();
        }

        public void AddUser(User user)
        {
            var users = GetAllUsers();
            users.Add(user);
            SaveAll(users);
        }

        public void DeleteUser(int userId)
        {
            var users = GetAllUsers();
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
