using BusinessObject;
using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSRepositories
{
    public interface IOrderRepositories
    {
        bool CheckProductsStatus(string userId);
        void CreateOrder(TbOrder order, string userId);
        List<TbOrder> GetPendingOrders(string userId);
        List<TbOrder> GetPurchasedOrders(string userId);
        List<ViewProduct> GetPendingProducts(string orderId);
        List<ViewProduct> GetPurchasedProducts(string orderId);
        List<ViewProduct> GetProductsIsPending();
        List<ViewProduct> GetProductsPurchased();
        List<ViewProduct> GetProductsCancelled();
        void OrderItemRequestCancellation(string id);
        void OrderItemConfirmation(string id);
        void OrderItemIsCancelling(string id);
        void OrderItemDenyCancelling(string id);
    }
}
