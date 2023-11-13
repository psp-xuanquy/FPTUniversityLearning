using Repositories.Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessObjects
{
    public class CategoryDAO
    {
        CategoryRepository repository;
        public CategoryDAO()
        {
            repository = new CategoryRepository();
        }

        public List<Category> GetAll()
        {
            return repository.GetAll().ToList();
        }
        public void Create(Category obj)
        {
            repository.Create(obj);
        }
        public void Update(Category obj)
        {
            repository.Update(obj);
        }
        public void Delete(Category obj)
        {
            repository.Delete(obj);
        }
    }
}
