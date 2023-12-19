using BSDAO;
using BusinessObject;
using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSRepositories
{
    public class OrderRepository : IOrderRepositories
    {
        public bool CheckProductsStatus(string userId) => OrderDAO.Instance.CheckProductsStatus(userId);

        public void CreateOrder(TbOrder order, string userId) => OrderDAO.Instance.CreateOrder(order, userId);

        public List<TbOrder> GetPendingOrders(string userId) => OrderDAO.Instance.GetPendingOrders(userId);

        public List<TbOrder> GetPurchasedOrders(string userId) => OrderDAO.Instance.GetPurchasedOrders (userId);

        public List<ViewProduct> GetPendingProducts(string orderId) => OrderDAO.Instance.GetPendingProducts(orderId);

        public List<ViewProduct> GetPurchasedProducts(string orderId) => OrderDAO.Instance.GetPurchasedProducts(orderId);

        public List<ViewProduct> GetProductsCancelled()=>OrderDAO.Instance.GetProductsCancelled();  
        
        public List<ViewProduct> GetProductsIsPending()=>OrderDAO.Instance.GetProductsIsPending();

        public List<ViewProduct> GetProductsPurchased()=>OrderDAO.Instance.GetProductsPurchased();

        public void OrderItemConfirmation(string id) => OrderDAO.Instance.OrderItemConfirmation(id);

        public void OrderItemDenyCancelling(string id) => OrderDAO.Instance.OrderItemDenyCancelling(id);

        public void OrderItemIsCancelling(string id) => OrderDAO.Instance.OrderItemIsCancelling(id);

        public void OrderItemRequestCancellation(string id) => OrderDAO.Instance.OrderItemRequestCancellation(id);
    }
}
