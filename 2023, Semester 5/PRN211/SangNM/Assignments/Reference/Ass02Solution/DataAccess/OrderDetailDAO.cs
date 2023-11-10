using BusinessObject;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDetailDAO
    {
        private static OrderDetailDAO instance;
        private static readonly object lockObject = new object();
        private List<OrderDetail> orderDetails;
        private OrderDetailDAO()
        {
            orderDetails = new List<OrderDetail>();
        }
        public static OrderDetailDAO Instance
        {
            get
            {
                lock(lockObject)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                }
                return instance;
            }
        }

    }
}
