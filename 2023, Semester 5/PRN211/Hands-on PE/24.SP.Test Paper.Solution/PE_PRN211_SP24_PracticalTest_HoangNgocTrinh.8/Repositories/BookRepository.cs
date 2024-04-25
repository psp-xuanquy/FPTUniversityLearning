using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BookRepository
    {
        //class này chơi trực tiếp với SQL Server qua DbContext (có sẵn CS)
        //class này sẽ bị gọi bởi class BookService
        //UI <---> BookService <----> BookRepository ----> DbContext <---> TABLE
        //[1]          [2]                  [3]
        //UI phải khai báo Service
        //              Service phải khai báo Repo
        //                                Repo phải khai báo Context
        //                                          Context phải Connection String 
        //TA Ở ĐÂY BỊ SERVICE GỌI 
        //TA Ở ĐÂY ĐI GỌI DBCONTEXT
        //TA CUNG CẤP CÁC HÀM CRUD TABLE BOOK CƠ BẢN
        //AddBook() UpdateBook() DeleteBook() GetBooks()  Get() lấy 1 cuốn

        //api/v2/books        -> lấy tất cả các cuốn sách
        //api/v2/books/123456 -> lấy cuốn sách mã 123456
        private BookManagementDbContext _context;
        //ko new, sẽ new ở từng hàm trong Repo!!! 

        public List<Book> GetBooks()
        {
            //_context = new BookManagementDbContext();
            _context = new();
            return _context.Books.ToList();
        }

        //hàm này sẽ cập nhật 1 cuốn sách có sẵn, phải nhờ đến DbContext như thường lệ
        //Cuốn sách book đưa cho hàm này từ trên UI -> Service -> đây là Repo -> gọi DbContext, chỗ nào đó phải new Book() và đẩy vào hàm này
        public void UpdateBook(Book book)
        {
            //_context = new BookManagementDbContext();
            _context = new();
            _context.Books.Update(book);  //SQL: UPDATE BOOK SET BOOKNAME = ... .... WHERE
                                          //     BOOKID = book.BookId 
            _context.SaveChanges();       //RUN CÂU SQL   
        }

        //Hàm này cần nhận vào 1 new Book(...) {} ở đâu đó. Chắc chắn từ UI mà đi xuống Service > Repo  > DbContext
        public void AddBook(Book book)
        {
            //_context = new BookManagementDbContext();
            _context = new();
            _context.Books.Add(book);  //SQL: INSERT BOOK VALUES(BookId = book.BookId,... 
            _context.SaveChanges();       //RUN CÂU SQL   
        }

        //1 cuốn sách đc new đâu đó và chuyển xuống đây
        public void DeleteBook(Book book)
        {
            //_context = new BookManagementDbContext();
            _context = new();
            _context.Books.Remove(book);  //SQL: DELETE FROM BOOK WHERE BookId
                                          //  = book.BookId 
            _context.SaveChanges();       //RUN CÂU SQL   
        }
    }

}
