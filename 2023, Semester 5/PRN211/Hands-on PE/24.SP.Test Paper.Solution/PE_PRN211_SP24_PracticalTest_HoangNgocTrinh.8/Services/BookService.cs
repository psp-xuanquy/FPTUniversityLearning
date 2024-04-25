using Repositories;
using Repositories.Entities;

namespace Services
{
    //3-layer Architecture:
    // [1]            [2]                [3]                          SQLSERVER        
    //UI-Forms  ---- Services  ------- Repositories -----------------    DB
    //MainUI    ---- BookService       BookRepository (Book Entity)    Book Table
    //  request/response         <----->      
    //  đưa data xuống DB                chơi trực tiếp DB: lên, xuống
    //  lấy data từ DB show                                 CRUD table thực sự
    //            RAM                             DB ĐĨA CỨNG HDD/SSD 
    public class BookService
    {
        //gọi Repo để lấy data từ DB thực sự
        //làm ẩu thì có thể gọi trực tiếp DbContext
        //làm 3-layer thì Service gọi Repo, Repo gọi DbContext, DbContext chứa kết nối CSDL
        //nhờ ai giúp thì phải khai báo người đó

        private BookRepository _repo = new BookRepository();
        public List<Book> GetAllBooks()
        {
            return _repo.GetBooks();
        }

        //hàm tạo mới cuối sách. Info cuốn sách láy từ UI đẩy thẳng xuống cho Repo giúp, Repo lại bán cái cho DbContext...
        public void AddBookFromUI(Book book)
        {
            _repo.AddBook(book); //chuyền banh theo dây chuyền UI -> Service -> Repo -> DbContext
        }  //Điều gì xảy ra nếu nhập trùng key
           //CHALLENGE: ChatGPT -> how to handle duplication of Primary Key Exception during creating a new Book in Book Management app
           //using Entity Framework Core in C#

        public void UpdateBookFromUI(Book book)
        {
            _repo.UpdateBook(book); //chuyền banh theo dây chuyền UI -> Service -> Repo -> DbContext
        }

        public void DeleteBookFromUI(Book book)
        {
            _repo.DeleteBook(book); //chuyền banh theo dây chuyền UI -> Service -> Repo -> DbContext
        }

    }
}
