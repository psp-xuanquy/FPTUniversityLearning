using CRMBook.Models;
using CRMBook.Repo;
using CRMBook.Sevices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Serilog;
using Ilogger = Serilog.ILogger;
namespace CRMBook.Controllers
{

    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly Ilogger _logger;
        private IBookRepo _bookRepo;
        private readonly IAuthencationServices _authencationServices;

        public BookController(IServiceProvider serviceProvider)
        {
            _bookRepo = serviceProvider.GetRequiredService<IBookRepo>();
            _logger = Log.Logger;
            _authencationServices = serviceProvider.GetRequiredService<IAuthencationServices>();
        }

        private static List<Book> Books = new List<Book>()
        {
            new Book()
            {
                Book_id = 0,
                Name = "chùm nho thịnh nộ",
                Author = "John Steinbeck",
                Category = "Fiction, Nobel",
                Description = "Câu chuyện xảy ra gần một thế kỷ trước: Gia đình Joad bỏ nhà cửa, ruộng đồng, mồ mả tổ tiên ở Oklahoma, tìm mọi cách chạy qua California để khỏi chết đói. ",
                Price = (decimal?)242.250,
            }
        };



        [HttpGet]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [Route("/api/[Controller]/get-all-Book")]
        public IActionResult GetAllBook()
        {
            var books = _bookRepo.GetAllBook();
            return Ok(books);
        }


        [HttpPost]
        [Route("/api/[Controller]/add-Book")]
        public IActionResult AddNewBook([FromBody] BookEntity book)
        {
            _logger.Information("Start add new book");
            var entity = new Book
            {
                Book_id = book.Book_id,
                Name = book.Name,
                Author = book.Author,
                Category = book.Category,
                Description = book.Description,
                Price = book.Price,
                Book_Accout_id = book.Accout_id
            };

            var existBook = _bookRepo.getBookById(id: book.Book_id);
            if (existBook != null)
            {
                return BadRequest($"Book has Id = {book.Book_id} has existed");
            }
            var save = _bookRepo.AddNewBook(entity);
            var jsonBook = JsonConvert.SerializeObject(Books);
            _logger.Information(jsonBook);
            return Ok(save == 1 ? "Success" : "failed");
        }

        [HttpPut]
        [Route("/api/[Controller]/update-Book")]
        public IActionResult updateBook([FromBody] BookEntity book)
        {
            _logger.Information("Update book");
            var existBook = _bookRepo.getBookById(id: book.Book_id);
            if (existBook == null)
            {
                return BadRequest($"Can't found book with this Id");
            }

            existBook.Book_id = book.Book_id;
            existBook.Name = book.Name;
            existBook.Author = book.Author;
            existBook.Category = book.Category;
            existBook.Description = book.Description;
            existBook.Price = book.Price;
            existBook.Book_Accout_id = book.Accout_id;

            var save = _bookRepo.UpdateBook(existBook, book.Book_id);
            var jsonBook = JsonConvert.SerializeObject(Books);
            _logger.Information(jsonBook);
            return Ok(save == 1 ? "Success" : "failed");

        }

        [HttpDelete]
        [Route("/api/[Controller]/delete-Book")]

        public IActionResult deleteBook(int id)
        {
            _logger.Information("Delete book");
            var existBook = _bookRepo.getBookById(id: id);
            if (existBook == null)
            {
                return BadRequest($"Can't found book with this Id");
            }

            var save = _bookRepo.DeleteBook(id);
            return Ok(save == 1 ? "Success" : "failed");
        }

        /*[HttpGet]
        [Route("/api/[Controller]/get-Book-id/{id}")]

        public IActionResult getBook(int id)
        {
            return Ok(Books.Where(_ => _.Id == id).SingleOrDefault());
        }*/

    }
}
