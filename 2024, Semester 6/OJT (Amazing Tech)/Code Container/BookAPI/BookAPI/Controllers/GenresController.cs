using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BookAPI.Repositories;
using BookAPI.Models;
using System;
using System.Threading.Tasks;

namespace BookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly IGenreRepository _genreRepository;

        public GenresController(IGenreRepository genreRepository)
        {
            _genreRepository = genreRepository;
        }

        [HttpGet("get-all-genres")]
        public IActionResult GetAllGenres()
        {
            try
            {
                var genres = _genreRepository.GetAllGenres();
                return Ok(genres);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("get-genre/{genreName}")]
        public IActionResult GetGenre(string genreName)
        {
            try
            {
                var genre = _genreRepository.GetGenreAsync(genreName).Result;

                if (genre != null)
                {
                    return Ok(genre);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost("add-genre")]
        public IActionResult AddGenre(GenreModel model)
        {
            try
            {
                var addedGenreName = _genreRepository.AddGenreAsync(model).Result;
                var addedGenre = _genreRepository.GetGenreAsync(addedGenreName).Result;

                return CreatedAtAction(nameof(GetGenre), new { genreName = addedGenreName }, addedGenre);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPut("update-genre/{genreName}")]
        public IActionResult UpdateGenre(string genreName, GenreModel model)
        {
            try
            {
                _genreRepository.UpdateGenreAsync(genreName, model).Wait();
                return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpDelete("delete-genre/{genreName}")]
        public IActionResult DeleteGenre(string genreName)
        {
            try
            {
                _genreRepository.DeleteGenreAsync(genreName).Wait();
                return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
