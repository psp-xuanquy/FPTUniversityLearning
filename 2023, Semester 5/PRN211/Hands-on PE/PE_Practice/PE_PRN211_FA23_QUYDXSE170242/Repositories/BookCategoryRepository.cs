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
        public List<BookCategory> GetAll()
        {
            return new BookManagement2023DbContext().BookCategories.ToList();
        }
    }
}
