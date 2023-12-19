using BusinessObject;
using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSDAO
{
    public class CartDAO
    {
        private static CartDAO instance = null;
        private CartDAO()
        {
        }

        public static CartDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CartDAO();
                }
                return instance;
            }
        }

        public bool AddToCart(string userId, string productId)
        {
            try
            {
                var dbContext = new BirdFarmShopContext();
                decimal total = 0;

                if (productId.StartsWith("BIRD"))
                {
                    var bird = dbContext.TbBirds.FirstOrDefault(b => b.BirdId == productId);
                    total = bird.Price;
                }
                else
                {
                    var nest = dbContext.TbNests.FirstOrDefault(b => b.NestId == productId);
                    total = nest.Price;
                }

                dbContext.TbCarts.Add(new TbCart
                {
                    UserId = userId,
                    ProductId = productId,
                    Total = total,
                });
                dbContext.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<ViewProduct> ViewCart(string userId)
        {
            var dbContext = new BirdFarmShopContext();
            ViewProductUltils viewProductUltils = new ViewProductUltils(dbContext);

            var cart = dbContext.TbCarts.Where(c => c.UserId == userId).ToList();

            var productList = new List<ViewProduct>();


            foreach (var item in cart)
            {
                productList.Add(viewProductUltils.GetProductById(item.ProductId));
            }
            return productList;
        }

        public bool RemoveCart(string userId)
        {
            try
            {
                var dbContext = new BirdFarmShopContext();
                var cartList = dbContext.TbCarts.Where(b => b.UserId == userId).ToList();

                foreach (var item in cartList)
                {
                    if (item.ProductId.StartsWith("BIRD"))
                    {
                        var bird = dbContext.TbBirds.FirstOrDefault(b => b.BirdId == item.ProductId && b.StatusSold == false);
                        bird.StatusSold = true;
                        dbContext.TbBirds.Update(bird);

                    }
                    else if(item.ProductId.StartsWith("NEST"))
                    {
                        var nest = dbContext.TbNests.FirstOrDefault(n => n.NestId == item.ProductId && n.Status == false);
                        nest.Status = true;
                        dbContext.TbNests.Update(nest);
                    }
                }

                dbContext.TbCarts.RemoveRange(cartList);
                dbContext.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool RemoveProductFromCart(string userId, string productId)
        {
            try
            {
                var dbContext = new BirdFarmShopContext();
                var product = dbContext.TbCarts.FirstOrDefault(c => c.UserId == userId && c.ProductId == productId);
                dbContext.TbCarts.Remove(product);
                dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
