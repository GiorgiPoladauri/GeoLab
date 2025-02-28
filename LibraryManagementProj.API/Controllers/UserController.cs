using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using LibraryManagementProj.API.DTOs;
using LibraryManagementProj.Application.Services.Abstractions;

namespace LibraryManagementProj.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // POST: api/User
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] UserDTO dto)
        {
            if (dto == null)
                return BadRequest("Invalid user data.");

            try
            {
                await _userService.AddUserAsync(dto.UserName, dto.PersonalNumber, dto.Email);
                return Ok("User created successfully.");
            }
            catch (Exception ex)
            {
                // Log exception if necessary
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/User/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, [FromBody] UserDTO dto)
        {
            if (dto == null)
                return BadRequest("Invalid user data.");

            try
            {
                await _userService.UpdateUserAsync(id, dto.UserName, dto.PersonalNumber, dto.Email);
                return Ok("User updated successfully.");
            }
            catch (Exception ex)
            {
                // Log exception if necessary
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/User/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            try
            {
                await _userService.DeleteUserAsync(id);
                return Ok("User deleted successfully.");
            }
            catch (Exception ex)
            {
                // Log exception if necessary
                return BadRequest(ex.Message);
            }
        }
    }
}
