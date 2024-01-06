using BookAPI.Data;
using BookAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookAPI.Repositories
{
    public interface IGenreRepository
    {
        Task<List<GenreModel>> GetAllGenresAsync();
        Task<GenreModel> GetGenreAsync(string genreName);
        Task<string> AddGenreAsync(GenreModel model);
        Task UpdateGenreAsync(string genreName, GenreModel model);
        Task DeleteGenreAsync(string genreName);

        bool GenreExists(string genreName);
    }
}
