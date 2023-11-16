using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public void Add(TblOrder order) => OrderDAO.Instance.Add(order);

        public void Delete(TblOrder order) => OrderDAO.Instance.Delete(order);

        public List<TblOrder> GetAll() => OrderDAO.Instance.GetAll();

        public TblOrder GetByID(Guid Guid) => OrderDAO.Instance.GetByID(Guid);

        public List<TblOrder> GetByStaff(string staffID) => OrderDAO.Instance.GetByStaffID(staffID);

        public List<TblOrder> GetByStatus(string status) => OrderDAO.Instance.GetByStatus(status);

        public void Update(TblOrder order) => OrderDAO.Instance.Update(order);
    }
}
