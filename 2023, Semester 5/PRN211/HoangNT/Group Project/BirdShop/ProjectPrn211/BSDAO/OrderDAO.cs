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
    public class OrderDAO
    {   
        
        private static OrderDAO instance = null;
        private OrderDAO()
        {
        }

        public static OrderDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderDAO();
                }
                return instance;
            }
        }

        public bool CheckProductsStatus(string userId)
        {
            var dbContext = new BirdFarmShopContext();
            var cartList = dbContext.TbCarts.Where(b => b.UserId == userId).ToList();

            foreach (var item in cartList)
            {
                if (item.ProductId.StartsWith("BIRD"))
                {
                    var bird = dbContext.TbBirds.FirstOrDefault(b => b.BirdId == item.ProductId && b.StatusSold == false);
                    if (bird == null)
                    {
                        throw new Exception("Sorry! Product:" + bird.Name + " Type of product: Nest \nHas been sold\nPlease remove product and order again");
                    }
                }
                else if (item.ProductId.StartsWith("NEST"))
                {
                    var nest = dbContext.TbNests.FirstOrDefault(n => n.NestId == item.ProductId && n.Status == false);
                    if (nest == null)
                    {
                        throw new Exception("Sorry! Product: " + nest.Name + " Type of product: Nest \nHas been sold\nPlease remove product and order again");
                    }
                }
            }
            return true;
        }

        public void CreateOrder(TbOrder order, string userId)
        {
            var db = new BirdFarmShopContext();

            var cartList = db.TbCarts
                .Where(c => c.UserId == userId)
                .ToList();

            var orderItemList = new List<TbOrderItem>();
            foreach (var cartItem in cartList)
            {   
                //Tạo OrderItem và thêm product trong Cart vào 
                var orderItem = new TbOrderItem 
                {
                    OrderItemId = "OI" + Guid.NewGuid().ToString(),
                    OrderId = order.OrderId,
                    ProductId = cartItem.ProductId,
                    Price = cartItem.Total,
                    StatusPending = true,
                    StatusProcess = true,
                    StatusCancel = false,
                };
                orderItemList.Add(orderItem);

                //Update Product status
                if (cartItem.ProductId.StartsWith("BIRD"))
                {
                    var bird = db.TbBirds.FirstOrDefault(b => b.BirdId == cartItem.ProductId && b.StatusSold == false);
                    bird.StatusSold = true;
                    db.TbBirds.Update(bird);

                }
                else if (cartItem.ProductId.StartsWith("NEST"))
                {
                    var nest = db.TbNests.FirstOrDefault(n => n.NestId == cartItem.ProductId && n.Status == false);
                    nest.Status = true;
                    db.TbNests.Update(nest);
                }
            }

            db.TbOrders.Add(order);
            db.TbOrderItems.AddRange(orderItemList);
            db.TbCarts.RemoveRange(cartList);
            db.SaveChanges();
        }

        public List<TbOrder> GetPendingOrders(string userId)
        {
            var db = new BirdFarmShopContext();
            return db.TbOrders
                .Include(o => o.User)
                .Include(o => o.PaymentMethod)
                .Include(o => o.Provider)
                .Where(o => o.UserId == userId && o.Status == true)
                .ToList();
        }

        public List<TbOrder> GetPurchasedOrders(string userId)
        {
            var db = new BirdFarmShopContext();
            return db.TbOrders
                .Include(o => o.User)
                .Include(o => o.PaymentMethod)
                .Include(o => o.Provider)
                .Where(o => o.UserId == userId && o.Status == false)
                .ToList();
        }

        public List<ViewProduct> GetPendingProducts(string orderId)
        {
            var db = new BirdFarmShopContext();
            ViewProductUltils viewProductUltils = new ViewProductUltils(db);

            var orderItemList = db.TbOrderItems.Where(oi => oi.OrderId == orderId && oi.StatusPending == true && oi.StatusProcess == true && oi.StatusCancel == false).ToList();

            var productList = new List<ViewProduct>();
            foreach (var product in orderItemList)
            {
                productList.Add(viewProductUltils.GetProductById(product.ProductId));
            }
            return productList;
        }

        public List<ViewProduct> GetPurchasedProducts(string orderId)
        {
            var db = new BirdFarmShopContext();
            ViewProductUltils viewProductUltils = new ViewProductUltils(db);

            var orderItemList = db.TbOrderItems.Where(oi => oi.OrderId == orderId && oi.StatusPending == false && oi.StatusProcess == false && oi.StatusCancel == false).ToList();

            var productList = new List<ViewProduct>();
            foreach (var product in orderItemList)
            {
                productList.Add(viewProductUltils.GetProductById(product.ProductId));
            }
            return productList;
        }

        public List<ViewProduct> GetProductsIsPending()
        {
            var db = new BirdFarmShopContext();
            ViewProductUltils viewProductUltils = new ViewProductUltils(db);
            var pendingList = db.TbOrderItems.Where(o=>o.StatusPending == true && o.StatusProcess==true&& o.StatusCancel==false).ToList();
            var orderItems = new List<ViewProduct>();
            foreach(var item in pendingList)
            {
                orderItems.Add(viewProductUltils.GetProductById(item.ProductId));
            }
            return orderItems;
        }

        public List<ViewProduct> GetProductsPurchased()
        {
            var db = new BirdFarmShopContext();
            ViewProductUltils viewProductUltils = new ViewProductUltils(db);
            var pendingList = db.TbOrderItems.Where(o => o.StatusPending == false && o.StatusProcess == false && o.StatusCancel == false).ToList();
            var orderItems = new List<ViewProduct>();
            foreach (var item in pendingList)
            {
                orderItems.Add(viewProductUltils.GetProductById(item.ProductId));
            }
            return orderItems;
        }

        public List<ViewProduct> GetProductsCancelled()
        {
            var db = new BirdFarmShopContext();
            ViewProductUltils viewProductUltils = new ViewProductUltils(db);
            var pendingList = db.TbOrderItems.Where(o => o.StatusPending == true && o.StatusProcess == true && o.StatusCancel == true).ToList();
            var orderItems = new List<ViewProduct>();
            foreach (var item in pendingList)
            {
                orderItems.Add(viewProductUltils.GetProductById(item.ProductId));
            }
            return orderItems;
        }

        public void OrderItemRequestCancellation(string id)
        {
            var db = new BirdFarmShopContext();
            var orderItem = db.TbOrderItems.FirstOrDefault(o => o.ProductId == id);
            if (orderItem.StatusPending == true && orderItem.StatusProcess == true && orderItem.StatusCancel == false)
            {
                orderItem.StatusPending = true;
                orderItem.StatusProcess = true;
                orderItem.StatusCancel = true;

                db.TbOrderItems.Update(orderItem);
                db.SaveChanges();
            }
        }

        public void OrderItemConfirmation(string id)
        {
            var db = new BirdFarmShopContext();
            var orderItem = db.TbOrderItems.FirstOrDefault(o => o.ProductId == id);
            orderItem.StatusPending = false;
            orderItem.StatusProcess = false;
            orderItem.StatusCancel = false;

            if (id.StartsWith("BIRD"))
            {
                var bird = db.TbBirds.FirstOrDefault(b => b.BirdId == id);
                bird.StatusSold = true;
                db.TbBirds.Update(bird);
            }
            else if (id.StartsWith("NEST"))
            {
                var nest = db.TbNests.FirstOrDefault(n => n.NestId == id);
                nest.Status = true;
                db.TbNests.Update(nest);
            }

            db.TbOrderItems.Update(orderItem);
            db.SaveChanges();
            UpdateOrderStatus(orderItem.OrderId);
            db.SaveChanges();
        }

        public void OrderItemIsCancelling(string id)
        {
            var db = new BirdFarmShopContext();
            var orderItem = db.TbOrderItems.FirstOrDefault(o=>o.ProductId== id);
            orderItem.StatusPending = false;
            orderItem.StatusProcess = false;
            orderItem.StatusCancel = true;

            if (id.StartsWith("BIRD"))
            {
                var bird=db.TbBirds.FirstOrDefault(b=>b.BirdId== id);
                bird.StatusSold = true;
                db.TbBirds.Update(bird);
            }else if (id.StartsWith("NEST"))
            {
                var nest = db.TbNests.FirstOrDefault(n => n.NestId == id);
                nest.Status = true;
                db.TbNests.Update(nest);
            }

            

            db.TbOrderItems.Update(orderItem);
            db.SaveChanges();

            UpdateOrderStatus(orderItem.OrderId);
            db.SaveChanges();
        }

        public void OrderItemDenyCancelling(string id)
        {
            var db = new BirdFarmShopContext();
            var orderItem = db.TbOrderItems.FirstOrDefault(o => o.ProductId == id);
            if(orderItem.StatusPending==true && orderItem.StatusProcess == true && orderItem.StatusCancel == true)
            {
                orderItem.StatusPending = true;
                orderItem.StatusProcess = true;
                orderItem.StatusCancel = false;

                db.TbOrderItems.Update(orderItem);
                db.SaveChanges();   
            }
        }
        
        private void UpdateOrderStatus(string orderId)
        {
            var db = new BirdFarmShopContext();
            var orderItem = db.TbOrderItems.Where(o => o.OrderId == orderId && o.StatusProcess == true).ToList();

            if (orderItem.Count == 0)
            {
                var order = db.TbOrders.FirstOrDefault(o => o.OrderId == orderId);
                order.Status = false;
                db.TbOrders.Update(order);
                db.SaveChanges();
            }
        }
    }
}
