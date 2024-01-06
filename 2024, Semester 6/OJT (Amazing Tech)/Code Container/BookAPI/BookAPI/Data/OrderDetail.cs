using System.ComponentModel.DataAnnotations;

namespace BookAPI.Data
{
    public class OrderDetail
    {
        public Guid BookId { get; set; }
        public Guid OrderId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public byte Discount { get; set; }

        
        public Order Order { get; set; }
        public Book Book { get; set; }
    }
}
