using AutoMapper;
using BookAPI.Data;
using BookAPI.Models;
using BookAPI.Models.App;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyApiNetCore6.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPI.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BookStoreContext _context;
        private readonly IMapper _mapper;
        private readonly ILogger<BookRepository> _logger;

        public BookRepository(BookStoreContext context, IMapper mapper, ILogger<BookRepository> logger)
        {
            _context = context;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<int> AddBookAsync(BookModel model)
        {
            try
            {
                var newBook = _mapper.Map<Book>(model);
                _context.Books!.Add(newBook);
                await _context.SaveChangesAsync();

                return newBook.BookId;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding book: {Message}", ex.Message);

                if (ex.InnerException != null)
                {
                    _logger.LogError(ex.InnerException, "Inner exception adding book: {Message}", ex.InnerException.Message);
                }

                return -1;
            }
        }

        public async Task DeleteBookAsync(int id)
        {
            var bookId = new Guid(id.ToString()); // Convert int to Guid
            var deleteBook = _context.Books!.SingleOrDefault(b => b.BookId == bookId);
            if (deleteBook != null)
            {
                _context.Books!.Remove(deleteBook);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<BookModel>> GetAllBooksAsync(string search, double? from, double? to, string sortBy, int page = 1)
        {
            var allBooks = _context.Books
                .Include(b => b.Genre)
                .Include(b => b.Author)
                .AsQueryable();

            #region Filtering
            if (!string.IsNullOrEmpty(search))
            {
                allBooks = allBooks.Where(b => b.Title.Contains(search));
            }
            if (from.HasValue)
            {
                allBooks = allBooks.Where(b => b.Price >= from);
            }
            if (to.HasValue)
            {
                allBooks = allBooks.Where(b => b.Price <= to);
            }
            #endregion

            #region Sorting
            // Default sort by Title
            allBooks = allBooks.OrderBy(b => b.Title);

            if (!string.IsNullOrEmpty(sortBy))
            {
                switch (sortBy)
                {
                    case "title_desc": allBooks = allBooks.OrderByDescending(b => b.Title); break;
                    case "price_asc": allBooks = allBooks.OrderBy(b => b.Price); break;
                    case "price_desc": allBooks = allBooks.OrderByDescending(b => b.Price); break;
                }
            }
            #endregion

            var result = PaginatedList<Book>.Create(allBooks, page, BookRepository.PAGE_SIZE);

            return _mapper.Map<List<BookModel>>(result);
        }

        public async Task<BookModel> GetBookAsync(int id)
        {
            var bookId = new Guid(id.ToString()); // Convert int to Guid
            var book = await _context.Books!.Include(b => b.Genre).Include(b => b.Author).FirstOrDefaultAsync(b => b.BookId == bookId);
            return _mapper.Map<BookModel>(book);
        }

        public async Task UpdateBookAsync(int id, BookModel model)
        {
            var bookId = new Guid(id.ToString()); // Convert int to Guid
            var existingBook = await _context.Books!.FirstOrDefaultAsync(b => b.BookId == bookId);

            if (existingBook != null)
            {
                _mapper.Map(model, existingBook);
                await _context.SaveChangesAsync();
            }
        }
    }
}
