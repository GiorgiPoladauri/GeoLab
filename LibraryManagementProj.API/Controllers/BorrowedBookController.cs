using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LibraryManagementProj.Application.Services.Abstractions;
using LibraryManagementProj.API.DTOs;

namespace LibraryManagementProj.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BorrowedBookController : ControllerBase
    {
        private readonly IBorrowBookService _borrowBookService;

        public BorrowedBookController(IBorrowBookService borrowBookService)
        {
            _borrowBookService = borrowBookService;
        }

        // POST: api/BorrowedBook/borrow
        // The user supplies only BookId and UserId.
        // The service will set BorrowDate to DateTime.Now and ReturnDate to DateTime.Now.AddMonths(1).
        [HttpPost("borrow")]
        public async Task<IActionResult> BorrowBook([FromBody] BorrowedBookDTO request)
        {
            if (request == null)
                return BadRequest("Invalid request.");

            try
            {
                await _borrowBookService.BorrowBookAsync(request.BookID, request.UserID);
                return Ok("Book borrowed successfully. Borrow date is set to now and return date is set to one month later.");
            }
            catch (Exception ex)
            {
                // Log exception details as needed.
                return BadRequest(ex.Message);
            }
        }

        // POST: api/BorrowedBook/return
        [HttpPost("return")]
        public async Task<IActionResult> ReturnBook([FromBody] BorrowedBookDTO request)
        {
            if (request == null)
                return BadRequest("Invalid request.");

            try
            {
                await _borrowBookService.ReturnBookAsync(request.BookID, request.UserID);
                return Ok("Book returned successfully.");
            }
            catch (Exception ex)
            {
                // Log exception details as needed.
                return BadRequest(ex.Message);
            }
        }
    }
}
