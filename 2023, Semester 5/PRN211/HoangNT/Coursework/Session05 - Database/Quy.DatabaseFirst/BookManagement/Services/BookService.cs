using Repositories;
using Repositories.Entities;

namespace Services
{
    /// <summary>
    /// Class này cung cấp các hàm cho bên UI/Form để load data hoặc nhận data từ UI/Form
    /// và nó sẽ giao tiếp vs UI để đồng bộ data và CSDL
    /// Tên hàm đặt dễ hiểu vì cung cấp cho UI xài
    /// </summary>

    public class BookService
    {
        private BookRepository _repo;
    
        //Hàm này trả ra tất cả sách đang có
        //Gọi Repo lấy giúp từ DB
        //Đc gọi bởi UI/Form để đổ Books vào grid/table trên Form
        public List<Book> GetAllBooks()
        {
            _repo = new BookRepository();
            return _repo.GetAll();
        }

        public List<Book> SearchBooks(string keyword)
        {
            List<Book> full = _repo.GetAll();
            List<Book> result = full.Where(book => 
            {
                if (book.BookName.ToLower().Contains(keyword) || book.Description.ToLower().Contains(keyword)) 
                    return true;
                return false;
            }).ToList();
            return result;
        }
    }
}
