using Repositories.Entities;
using Repositories;

namespace Services
{
    /// <summary>
    /// Class này lấy data từ Repo đẩy lên cho From - UI hiển thị cho user
    /// hoặc lấy data từ Form -UI đẩy ngược lại xuống Repo xuống DB
    /// Chứa các hàm gọi CRUD từ Repo, có thể tính toán dùng LINQ 
    /// Bên cung cấp dịch vụ cho user
    /// 
    /// </summary>
    public class CategoryService
    {
        private CategoryRepository _repo;

        public List<BookCategory> GetAllCategories()
        {
            _repo = new CategoryRepository();
            return _repo.GetAll();
        }
    }
}
