using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BookCategoryRepository
    {
        //lại vẫn phải mượn tay của DbContext để giúp xuống DB
        private BookManagementDbContext _context;
        //ko new, sẽ new ở từng hàm trong Repo!!! 

        //lấy tất cả BookCategory - hiện có 5 dòng để đổ vào dropdown/combo box bên form Detail
        public List<BookCategory> GetBookCategories()
        {
            //_context = new BookManagementDbContext();
            _context = new();
            return _context.BookCategories.ToList();
        }
    }
}
