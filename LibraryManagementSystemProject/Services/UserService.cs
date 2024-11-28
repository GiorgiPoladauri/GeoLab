using LibraryManagementSystemProject.Models;
using LibraryManagementSystemProject.Repositories;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibraryManagementSystemProject.Services
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
            var users = _userRepository.GetAll();

            var user = new User
            {
                UserId = users.Count > 0 ? users.Max(u => u.UserId) + 1 : 1,
                Name = name,
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
                MessageBox.Show("Error: Invalid or duplicate email.");
                return;
            }

            else 
            {
                _userRepository.Add(user);
                MessageBox.Show("User has been registered");
            }
        }

        public void DeleteUser(int userId)
        {
            var users = _userRepository.GetAll();
            var userToDelete = users.FirstOrDefault(u => u.UserId == userId);

            if (userToDelete == null)
            {
                MessageBox.Show("User has not been found.");
                return;
            }

            else
            {
                _userRepository.Delete(userId);
                MessageBox.Show("User deleted.");
            }
        }
    }
}
