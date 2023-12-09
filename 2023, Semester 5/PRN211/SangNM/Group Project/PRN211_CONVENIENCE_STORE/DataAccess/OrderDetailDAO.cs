using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class OrderDetailDAO
    {
        // ----------------------------------------------- Singleton Pattern -----------------------------------------------

        private static OrderDetailDAO instance = null;
        private static readonly object instanceLock = new object();
        private OrderDetailDAO() { }
        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                    return instance;
                }
            }
        }


        // -----------------------------------------------------------

        public List<TblOrderDetail> GetAll()
        {
            List<TblOrderDetail> orderDetails = null;
            try
            {
                using (var ctx = new prn211group4Context())
                {
                    orderDetails = ctx.TblOrderDetails.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orderDetails;
        }

        public TblOrderDetail GetByIDs(Guid orderId,string productId)
        {
            TblOrderDetail orderDetails = null;
            try
            {
                using (var ctx = new prn211group4Context())
                {
                    orderDetails = ctx.TblOrderDetails.SingleOrDefault(order => order.OrderId.Equals(orderId) && order.ProductId.Equals(productId));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orderDetails;
        }

        public List<TblOrderDetail> GetListByID(Guid orderId)
        {
            List<TblOrderDetail> orderDetails = null;
            try
            {
                using (var ctx = new prn211group4Context())
                {
                    orderDetails = ctx.TblOrderDetails.Where(order => order.OrderId.Equals(orderId)).ToList<TblOrderDetail>();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orderDetails;
        }


        public void Add(TblOrderDetail orderDetail)
        {
            try
            {
                using (var ctx = new prn211group4Context())
                {
                    ctx.TblOrderDetails.Add(orderDetail);
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }


        public void Update(TblOrderDetail orderDetail)
        {
            try
            {
                using (var ctx = new prn211group4Context())
                {
                    ctx.Entry(orderDetail).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

