using BusinessObject;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDAO
    {
        private static OrderDAO instance;
        private static readonly object lockObject = new object();
        private List<Order> orders;
        private OrderDAO()
        {
            orders = new List<Order>();
        }
        public static OrderDAO Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                }
                return instance;
            }
        }

    }
}
