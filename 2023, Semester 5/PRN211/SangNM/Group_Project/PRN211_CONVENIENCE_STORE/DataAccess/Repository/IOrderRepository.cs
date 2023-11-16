using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        /// <summary>
        ///    Return a list of Orders
        /// </summary>
        List<TblOrder> GetAll();

        /// <summary>
        ///    Return order by Guuid
        /// </summary>
        TblOrder GetByID(Guid Guid);

        /// <summary>
        ///    Return a list of Orders using Status
        /// </summary>
        List<TblOrder> GetByStatus(string status);

        /// <summary>
        ///    Return a list of Orders using Staff
        /// </summary>
        List<TblOrder> GetByStaff(string staffID);

        /// <summary>
        ///    Add an Order
        /// </summary>
        void Add(TblOrder order);

        /// <summary>
        ///    Set order status to "DELETED"
        /// </summary>
        void Delete(TblOrder order);

        /// <summary>
        ///   Update and order
        /// </summary>
        void Update(TblOrder order);
    }
}
