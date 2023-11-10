using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public List<TblOrderDetail> GetAll() => OrderDetailDAO.Instance.GetAll();

        public TblOrderDetail GetByIDs(Guid orderId, string productId) => OrderDetailDAO.Instance.GetByIDs(orderId, productId);

        public List<TblOrderDetail> GetListByID(Guid orderId) => OrderDetailDAO.Instance.GetListByID(orderId);


        public void Add(TblOrderDetail orderDetail) => OrderDetailDAO.Instance.Add(orderDetail);


        public void Update(TblOrderDetail orderDetail) => OrderDetailDAO.Instance.Update(orderDetail);
    }
}
