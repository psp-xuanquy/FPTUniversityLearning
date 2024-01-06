using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using AutoMapper;
using BookAPI.Repositories;
using BookAPI.Models;
using MyApiNetCore6.Repositories;

namespace BookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _bookRepo;
        private readonly IMapper _mapper;
        private readonly ILogger<BooksController> _logger;

        public BooksController(IBookRepository bookRepo, IMapper mapper, ILogger<BooksController> logger)
        {
            _bookRepo = bookRepo;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBooks(string search, double? from, double? to, string sortBy, int page = 1)
        {
            try
            {
                var books = await _bookRepo.GetAllBooksAsync();
                // Additional logic for filtering, sorting, and paging can be added here
                return Ok(books);
            }
            catch
            {
                return BadRequest("We can't get the books.");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBook(int id)
        {
            try
            {
                var book = await _bookRepo.GetBookAsync(id);
                if (book == null)
                {
                    return NotFound();
                }
                return Ok(book);
            }
            catch
            {
                return BadRequest("We can't get the book.");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(BookModel bookModel)
        {
            try
            {
                var newBookId = await _bookRepo.AddBookAsync(bookModel);
                var newBook = await _bookRepo.GetBookAsync(newBookId);

                return CreatedAtAction(nameof(GetBook), new { id = newBookId }, newBook);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding book: {Message}", ex.Message);

                if (ex.InnerException != null)
                {
                    _logger.LogError(ex.InnerException, "Inner exception adding book: {Message}", ex.InnerException.Message);
                }

                return StatusCode(500, new { Success = false, Message = "Error adding book" });
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook(int id, BookModel bookModel)
        {
            try
            {
                await _bookRepo.UpdateBookAsync(id, bookModel);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating book: {Message}", ex.Message);
                return BadRequest("We can't update the book.");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            try
            {
                await _bookRepo.DeleteBookAsync(id);
                return NoContent();
            }
            catch
            {
                return BadRequest("We can't delete the book.");
            }
        }
    }
}
