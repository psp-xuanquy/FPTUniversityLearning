using Repositories.Models;
using Repositories;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessObjects
{
    public class OrderDetailDAO
    {
        OrderDetailRepository repository;
        public OrderDetailDAO()
        {
            repository = new OrderDetailRepository();
        }

        public List<OrderDetail> GetAll()
        {
            return repository.GetAll().ToList();
        }
        public void Create(OrderDetail obj)
        {
            repository.Create(obj);
        }
        public void Update(OrderDetail obj)
        {
            repository.Update(obj);
        }
        public void Delete(OrderDetail obj)
        {
            repository.Delete(obj);
        }
    }
}
