using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderDetailRepository
    {
        List<TblOrderDetail> GetAll();

        TblOrderDetail GetByIDs(Guid orderId, string productId);

        List<TblOrderDetail> GetListByID(Guid orderId);


        void Add(TblOrderDetail order);


        void Update(TblOrderDetail order);
    }
}
    

