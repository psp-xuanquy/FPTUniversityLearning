using BookAPI.Attribute;
using BookAPI.Data.Entity;
using BookAPI.Enum;
using BookAPI.Model;
using BookAPI.Services;
using DocnetCorePractice.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using Ilogger = Serilog.ILogger;

namespace BookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly Ilogger _logger;
        private readonly IAuthenticationService _authenticationService;
        public IUserService _userService;
        public BooksController(IServiceProvider serviceProvider)
        {
            _authenticationService = serviceProvider.GetRequiredService<IAuthenticationService>();
            _userService = serviceProvider.GetRequiredService<IUserService>();
            _logger = Log.Logger;
        }


        private static List<UserEntity> users = new List<UserEntity>()
        {
            new UserEntity()
            {
                Id = Guid.NewGuid().ToString("N"),
                FirstName = "Quy",
                LastName = "Xuan",
                Sex = Enum.Sex.Male,
                Address = "Ho chi Minh",
                Balance = 100000,
                DateOfBirth = DateTime.Now,
                PhoneNumber = "0123456789",
                Roles = Enum.Roles.Basic,
                TotalProduct = 0,
                IsActive = true
            }
        };

        private static List<BookEntity> books = new List<BookEntity>
        {
            new BookEntity()
            {
                Id = Guid.NewGuid().ToString("N"),
                BookName = "The Adventurer's Quest",
                BookGenreType = GenreType.Action,
                Author = "Alex Explorer",
                Quantity = 10,
                Price = 19.99,
                Discount = 5,
                IsActive = true
            },
            new BookEntity
            {
                Id = Guid.NewGuid().ToString("N"),
                BookName = "Love Beyond Time",
                BookGenreType = GenreType.Romance,
                Author = "Sophia Romance",
                Quantity = 8,
                Price = 17.99,
                Discount = 8,
                IsActive = true
            },
            new BookEntity
            {
                Id = Guid.NewGuid().ToString("N"),
                BookName = "Laugh Factory",
                BookGenreType = GenreType.Comedy,
                Author = "Charlie Chuckles",
                Quantity = 12,
                Price = 15.99,
                Discount = 10,
                IsActive = true
            },
            new BookEntity
            {
                Id = Guid.NewGuid().ToString("N"),
                BookName = "Tears of Redemption",
                BookGenreType = GenreType.Drama,
                Author = "Olivia Drama",
                Quantity = 15,
                Price = 22.99,
                Discount = 12,
                IsActive = true
            },
            new BookEntity
            {
                Id = Guid.NewGuid().ToString("N"),
                BookName = "The Haunting Shadows",
                BookGenreType = GenreType.Horror,
                Author = "David Fearson",
                Quantity = 10,
                Price = 24.99,
                Discount = 15,
                IsActive = true
            }
        };

        [HttpPost]
        [Route("/api/[controller]/login")]
        public IActionResult Login(RequestLoginModel request)
        {
            return Ok(_authenticationService.Authenticator(request));
        }

        [ApiKey]
        [Authorize(AuthenticationSchemes = "Bearer")]
        [HttpGet("/api/[controller]/getalluser")]
        public IActionResult GetAllUser()
        {
            var result = _userService.GetAllUser();
            return Ok(result);
        }


        [HttpPost("/api/[controller]/adduser")]
        public IActionResult AddUser([FromBody] UserModel model)
        {
            var result = _userService.AddUser(model);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetBooks()
        {
            return Ok(books);
        }
    }
}
