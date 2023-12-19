using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDAO
{
    public class PaymentMethodDAO
    {
        private static PaymentMethodDAO instance = null;

        public PaymentMethodDAO()
        {
        }
        public static PaymentMethodDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new PaymentMethodDAO();
                }
                return instance;
            }
        }

        public List<TbPaymentMethod> GetPaymentMethods()
        {
            var db = new BirdFarmShopContext();
            return db.TbPaymentMethods.ToList();
        }
    }
}
