namespace BookAPI.Data
{
    public enum OrderStatus
    {
        New = 0,
        Payment = 1,
        Complete = 2,
        Cancel = -1
    }
    public class Order
    {
        public Guid OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public string Consignee { get; set; }
        public string DeliveryAddress { get; set; }
        public string PhoneNumber { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }

        public Order()
        {
            OrderDetails = new List<OrderDetail>();
        }

    }
}
