using LibraryManagementProj.API.DTOs;
using LibraryManagementProj.Application.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace LibraryManagementProj.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        // POST: api/Book
        [HttpPost]
        public async Task<IActionResult> CreateBook([FromBody] CreateOrUpdateBookDto dto)
        {
            try
            {
                // In a more complex scenario, you might map the DTO to a domain model.
                // For now, we're directly passing the DTO values to the service.
                await _bookService.AddBookAsync(
                    dto.BookName,
                    dto.Description,
                    dto.PublicationDate,
                    dto.AuthorName,
                    dto.Pages,
                    dto.Quantity
                    );
                return Ok("Book created successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/Book/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook(int id, [FromBody] CreateOrUpdateBookDto dto)
        {
            try
            {
                await _bookService.UpdateBookAsync(
                    id,
                    dto.BookName,
                    dto.Description,
                    dto.PublicationDate,
                    dto.AuthorName,
                    dto.Pages,
                    dto.Quantity);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/Book/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            try
            {
                await _bookService.DeleteBookAsync(id);
                return Ok("Book deleted successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
