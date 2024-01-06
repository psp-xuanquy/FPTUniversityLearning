using BookAPI.Data;
using BookAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookAPI.Repositories
{
    public interface IAuthorRepository
    {
        Task<IEnumerable<AuthorModel>> GetAllAuthorsAsync();
        Task<AuthorModel> GetAuthorAsync(string authorName);
        Task<string> AddAuthorAsync(AuthorModel authorModel);
        Task UpdateAuthorAsync(string authorName, AuthorModel authorModel);
        Task DeleteAuthorAsync(string authorName);
    }
}
