using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ProductDAO
    {
        private static ProductDAO instance;
        private static readonly object lockObject = new object();
        private List<Product> products;
        private ProductDAO()
        {
            products = new List<Product>();
        }
        public static ProductDAO Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                }
                return instance;

            }
        }
    }
}
