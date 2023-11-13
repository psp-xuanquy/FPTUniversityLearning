
using Repositories;
using Repositories.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessObjects
{
    public class ProductDAO
    {
        ProductRepository repository;
        public ProductDAO()
        {
            repository = new ProductRepository();
        }

        public List<Product> GetAll()
        {
            return repository.GetAll().ToList();
        }
        public void Create(Product obj)
        {
            repository.Create(obj);
        }
        public void Update(Product obj)
        {
            repository.Update(obj);
        }
        public void Delete(Product obj)
        {
            repository.Delete(obj);
        }

    }
}
