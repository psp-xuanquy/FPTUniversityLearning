using BSDAO;
using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSRepositories
{
    public class PaymentMethodRepository : IPaymentMethodRepositories
    {
        public List<TbPaymentMethod> GetPaymentMethods() => PaymentMethodDAO.Instance.GetPaymentMethods();

    }
}
