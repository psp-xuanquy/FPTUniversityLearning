using AutoMapper;
using BookAPI.Data;
using BookAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPI.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        private readonly BookStoreContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<GenreRepository> _logger;

        public GenreRepository(BookStoreContext context, IMapper mapper, ILogger<GenreRepository> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<List<GenreModel>> GetAllGenresAsync()
        {
            try
            {
                var genres = await _context.Genres.ToListAsync();
                return _mapper.Map<List<GenreModel>>(genres);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting all genres: {Message}", ex.Message);
                return null;
            }
        }

        public async Task<GenreModel> GetGenreAsync(string genreName)
        {
            try
            {
                var genre = await _context.Genres.FindAsync(genreName);
                return _mapper.Map<GenreModel>(genre);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting genre: {Message}", ex.Message);
                return null;
            }
        }

        public async Task<string> AddGenreAsync(GenreModel model)
        {
            try
            {
                var newGenre = _mapper.Map<Genre>(model);
                _context.Genres.Add(newGenre);
                await _context.SaveChangesAsync();

                return newGenre.GenreName;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding genre: {Message}", ex.Message);
                return null;
            }
        }

        public async Task UpdateGenreAsync(string genreName, GenreModel model)
        {
            try
            {
                var existingGenre = await _context.Genres.FindAsync(genreName);

                if (existingGenre != null)
                {
                    _mapper.Map(model, existingGenre);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating genre: {Message}", ex.Message);
            }
        }

        public async Task DeleteGenreAsync(string genreName)
        {
            try
            {
                var genre = await _context.Genres.FindAsync(genreName);
                if (genre != null)
                {
                    _context.Genres.Remove(genre);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting genre: {Message}", ex.Message);
            }
        }

        public bool GenreExists(string genreName)
        {
            return _context.Genres.Any(e => e.GenreName == genreName);
        }
    }
}
