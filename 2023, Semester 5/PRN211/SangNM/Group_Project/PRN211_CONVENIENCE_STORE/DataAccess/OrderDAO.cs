using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDAO
    {
        // ----------------------------------------------- Singleton Pattern -----------------------------------------------

        private static OrderDAO instance = null;
        private static readonly object instanceLock = new object();
        private OrderDAO() { }
        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }


        // -----------------------------------------------------------

        public List<TblOrder> GetAll()
        {
            List<TblOrder> orders = null;
            try
            {
                using (var ctx = new prn211group4Context())
                {
                    orders = ctx.TblOrders.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }


 
        public TblOrder GetByID(Guid orderId)
        {
            TblOrder order = null;
            try
            {
                using (var ctx = new prn211group4Context())
                {
                    order = ctx.TblOrders.SingleOrDefault(order => order.OrderId.Equals(orderId));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return order;
        }

        public List<TblOrder> GetByStatus(string statusId)
        {
            List<TblOrder> orders = null;
            try
            {
                using (var ctx = new prn211group4Context())
                {
                    orders = ctx.TblOrders.Where(order => order.StatusId.Equals(statusId)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }

        public List<TblOrder> GetByStaffID(string staffID)
        {
            List<TblOrder> orders = null;
            try
            {
                using (var ctx = new prn211group4Context())
                {
                    orders = ctx.TblOrders.Where(order => order.StaffId.Contains(staffID)).ToList<TblOrder>();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return orders;
        }   

        public void Add(TblOrder order)
        {
            try
            {
                using (var ctx = new prn211group4Context())
                {
                    ctx.TblOrders.Add(order);
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public void Delete(TblOrder order)
        {
            try
            {
                using (var ctx = new prn211group4Context())
                {
                    // Old Delete Method
                    //ctx.TblOrders.Remove(order);
                    //ctx.SaveChanges();

                    // Set statusId to DELETED
                    order.StatusId = "DELETED";
                    ctx.Entry(order).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    ctx.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void Update(TblOrder order)
        {
            try
            {
                using (var ctx = new prn211group4Context())
                {
                    ctx.Entry(order).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
