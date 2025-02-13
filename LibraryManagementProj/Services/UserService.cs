using LibraryManagementProj.Models;
using LibraryManagementProj.Repositories;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibraryManagementProj.Services
{
    public class UserService
    {
        private UserRepository _userRepository;

        public UserService()
        {
            _userRepository = new UserRepository("users.json");
        }

        public void RegisterUser(string name, string personalNumber, string email)
        {
            var users = _userRepository.GetAllUsers();

            var user = new User
            {
                UserID = users.Count > 0 ? users.Max(u => u.UserId) + 1 : 1,
                UserName = name,
                PersonalNumber = personalNumber,
                Email = email
            };

            if (personalNumber.Length != 11 || users.Any(u => u.PersonalNumber == personalNumber))
            {
                MessageBox.Show("Error: Invalid or duplicate personal number.", "You joking ?", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(email) || !email.Contains('@') || users.Any(u => u.Email == email))
            {
                throw new("Error: Invalid or duplicate email.");
            }

            else 
            {
                _userRepository.AddUser(user);
                throw new("User has been registered");
            }
        }

        public void DeleteUser(int userId)
        {
            var users = _userRepository.GetAllUsers();
            var userToDelete = users.FirstOrDefault(u => u.UserId == userId);

            if (userToDelete == null)
            {
                throw new("User has not been found.");
            }

            else
            {
                _userRepository.DeleteUser(userId);
                throw new("User deleted.");
            }
        }
    }
}
