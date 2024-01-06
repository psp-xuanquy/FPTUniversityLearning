using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BookAPI.Repositories;
using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using BookAPI.Models;

namespace BookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorsController(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository ?? throw new ArgumentNullException(nameof(authorRepository));
        }

        [HttpGet("get-all-authors")]
        public async Task<IActionResult> GetAllAuthors()
        {
            try
            {
                var authors = await _authorRepository.GetAllAuthorsAsync();

                var settings = new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                    NullValueHandling = NullValueHandling.Ignore
                };

                var json = JsonConvert.SerializeObject(authors, Formatting.Indented, settings);
                return Ok(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetAllAuthors: {ex}");
                return BadRequest(new { ErrorMessage = ex.Message });
            }
        }

        [HttpGet("get-author/{authorName}")]
        public async Task<IActionResult> GetAuthor(string authorName)
        {
            var author = await _authorRepository.GetAuthorAsync(authorName);

            if (author == null)
            {
                return NotFound();
            }

            var settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                NullValueHandling = NullValueHandling.Ignore
            };

            var json = JsonConvert.SerializeObject(author, Formatting.Indented, settings);
            return Ok(json);
        }

        [HttpPost("add-author")]
        public async Task<IActionResult> AddAuthor(AuthorModel author)
        {
            try
            {
                var newAuthorName = await _authorRepository.AddAuthorAsync(author);
                var addedAuthor = await _authorRepository.GetAuthorAsync(newAuthorName);

                return addedAuthor == null ? NotFound() : CreatedAtAction(nameof(GetAuthor), new { authorName = newAuthorName }, addedAuthor);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in AddAuthor: {ex}");
                return BadRequest(new { ErrorMessage = ex.Message });
            }
        }

        [HttpPut("update-author/{authorName}")]
        public async Task<IActionResult> UpdateAuthor(string authorName, [FromBody] AuthorModel author)
        {
            try
            {
                await _authorRepository.UpdateAuthorAsync(authorName, author);
                var updatedAuthor = await _authorRepository.GetAuthorAsync(authorName);

                return updatedAuthor == null ? NotFound() : Ok(updatedAuthor);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in UpdateAuthor: {ex}");
                return BadRequest(new { ErrorMessage = ex.Message });
            }
        }

        [HttpDelete("delete-author/{authorName}")]
        public async Task<IActionResult> DeleteAuthor([FromRoute] string authorName)
        {
            await _authorRepository.DeleteAuthorAsync(authorName);
            return Ok();
        }
    }
}
