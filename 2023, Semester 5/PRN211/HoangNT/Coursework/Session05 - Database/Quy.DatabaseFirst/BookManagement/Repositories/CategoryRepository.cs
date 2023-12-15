using Repositories.Entities;

namespace Repositories
{

    /// <summary>
    /// Class này dùng để thao tác trên các object của Category
    /// tức là CRUD Category
    /// và Category lại map xuống table Category
    /// nên class này sẽ xài DbContext để đẩy cái List<Category> xuống DB 
    /// </summary>
    /// 

    public class CategoryRepository
    {
        private BookManagement2023DBContext db;

        private List<BookCategory> _list;

        public List<BookCategory> GetAll()
        {
            db = new BookManagement2023DBContext();
            return db.BookCategories.ToList();
        }
    }
}
