using AutoMapper;
using BookAPI.Data;
using BookAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookAPI.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly BookStoreContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<AuthorRepository> _logger;

        public AuthorRepository(BookStoreContext context, IMapper mapper, ILogger<AuthorRepository> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<IEnumerable<AuthorModel>> GetAllAuthorsAsync()
        {
            var authors = await _context.Authors!.Include(a => a.Books).ToListAsync();
            return _mapper.Map<List<AuthorModel>>(authors);
        }

        public async Task<AuthorModel> GetAuthorAsync(string authorName)
        {
            var author = await _context.Authors!.Include(a => a.Books).FirstOrDefaultAsync(a => a.AuthorName == authorName);
            return _mapper.Map<AuthorModel>(author);
        }

        public async Task<string> AddAuthorAsync(AuthorModel authorModel)
        {
            try
            {
                var newAuthor = _mapper.Map<Author>(authorModel);
                _context.Authors!.Add(newAuthor);
                await _context.SaveChangesAsync();

                return newAuthor.AuthorName;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding author: {Message}", ex.Message);

                if (ex.InnerException != null)
                {
                    _logger.LogError(ex.InnerException, "Inner exception adding author: {Message}", ex.InnerException.Message);
                }

                return string.Empty;
            }
        }

        public async Task UpdateAuthorAsync(string authorName, AuthorModel authorModel)
        {
            var existingAuthor = await _context.Authors!.Include(a => a.Books)
                                                        .FirstOrDefaultAsync(a => a.AuthorName == authorName);

            if (existingAuthor != null)
            {
                _mapper.Map(authorModel, existingAuthor);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteAuthorAsync(string authorName)
        {
            var author = await _context.Authors!.FirstOrDefaultAsync(a => a.AuthorName == authorName);

            if (author != null)
            {
                _context.Authors!.Remove(author);
                await _context.SaveChangesAsync();
            }
        }
    }
}
