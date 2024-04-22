using Repositories.Entities;

namespace Repositories
{
    /// <summary>
    /// Class này chơi trực tiếp vs CSDL, tức là xài DbContext để CRUD table
    /// Và đc gọi bởi class Services
    /// Chứa các hàm CRUD cơ bản trên table Book có thể sẽ join vs tavle Category
    /// </summary>
    public class BookRepository
    {
        private BookManagement2023DBContext _db;

        /// <summary>
        /// Hàm này trả về tất cả các cuốn sách có trong CSDL/ trong table Book
        /// Lưu ý việc JOIN để sau này lấy đc info của Category
        /// </summary>
        /// <returns></returns>
        public List<Book> GetAll()
        {
            _db = new BookManagement2023DBContext();
            return _db.Books.ToList();
        }
    }
}
