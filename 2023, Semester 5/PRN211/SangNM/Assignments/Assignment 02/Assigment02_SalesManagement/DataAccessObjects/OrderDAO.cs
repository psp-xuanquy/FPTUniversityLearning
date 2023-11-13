using Repositories;
using Repositories.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessObjects
{
    public class OrderDAO
    {
        OrderRepository repository;
        public OrderDAO()
        {
            repository = new OrderRepository();
        }

        public List<Order> GetAll()
        {
            return repository.GetAll().ToList();
        }
        public void Create(Order obj)
        {
            repository.Create(obj);
        }
        public void Update(Order obj)
        {
            repository.Update(obj);
        }
        public void Delete(Order obj)
        {
            repository.Delete(obj);
        }
    }
}
