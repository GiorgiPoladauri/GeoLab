using LibraryManagementProj.Core.Models;
using LibraryManagementProj.Core.Interfaces.IRepositories;
using LibraryManagementProj.Application.Services.Abstractions;

namespace LibraryManagementProj.Application.Services.Implementation
{
    public class UserService : IUserService
    {
        public readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task AddUserAsync(string username, string personalnumber, string email)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new Exception("User name can't be empty.");
            }
            if (username.Length > 40 || username.Length < 2)
            {
                throw new Exception("User name is either too short or long...");
            }
            if (personalnumber.Length != 11)
            {
                throw new Exception("Personal number length should be 11.");
            }
            if (string.IsNullOrEmpty(email))
            {
                throw new Exception("Email can't be empty");
            }

            var user = new User(username, personalnumber, email);

            await _userRepository.AddUserAsync(user);
        }

        public async Task DeleteUserAsync(int userid)
        {
            var user = await
                _userRepository.GetUserByIDAsync(userid);
            if (user == null)
                throw new Exception("User not found.");

            await _userRepository.DeleteUserAsync(userid);
        }

        public async Task UpdateUserAsync(int userid, string username, string personalnumber, string email)
        {
            var user = await
                _userRepository.GetUserByIDAsync(userid);
            if (user == null)
                throw new Exception("User not found");

            await _userRepository.UpdateUserAsync(user);
        }

    }
}
