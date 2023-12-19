using BSDAO;
using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSRepositories
{
    public class CartRepository : ICartRepositories
    {
        public bool AddToCart(string userId, string productId)
        {
            try
            {
                return CartDAO.Instance.AddToCart(userId, productId);
            }
            catch (Exception ex)
            {
                throw new Exception("Error add to cart : " + ex.Message);
            }
        }

        public bool RemoveCart(string userId)
        {
            try
            {
                return CartDAO.Instance.RemoveCart(userId);
            }
            catch (Exception ex)
            {
                throw new Exception("Error remove cart : " + ex.Message);
            }
        }

        public bool RemoveProductFromCart(string userId, string productId)
        {
            try
            {
                return CartDAO.Instance.RemoveProductFromCart(userId, productId);
            }
            catch (Exception ex)
            {
                throw new Exception("Error remove cart : " + ex.Message);
            }
        }

        public List<ViewProduct> ViewCart(string userId)
        {
            try
            {
                return CartDAO.Instance.ViewCart(userId);
            }
            catch (Exception ex)
            {
                throw new Exception("Error view cart : " + ex.Message);
            }
        }
    }
}
