using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSRepositories
{
    public interface ICartRepositories
    {
        public bool AddToCart(string userId, string productId);
        public List<ViewProduct> ViewCart(string userId);
        public bool RemoveCart(string userId);
        public bool RemoveProductFromCart(string userId, string productId);

    }
}
