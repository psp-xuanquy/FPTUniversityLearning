using BookAPI.Data.Entity;
using BookAPI.Enum;
using System.Linq;

namespace DocnetCorePractice.Data
{
    public interface IInitData
    {
        List<UserEntity> GetAllUser();
        bool AddUser(UserEntity entity);
    }
    public class InitData : IInitData
    {
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

        private static List<OrderItemEntity> orderItems = new List<OrderItemEntity>();
        private static List<OrderEntity> orders = new List<OrderEntity>();

        public List<UserEntity> GetAllUser()
        {
            return users.Where(x => x.IsActive == true).ToList();
        }

        public bool AddUser(UserEntity entity)
        {
            users.Add(entity);
            return true;
        }
    }
}
