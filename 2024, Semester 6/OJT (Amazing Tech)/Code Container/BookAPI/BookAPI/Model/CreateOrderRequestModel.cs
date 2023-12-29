namespace BookAPI.Model
{
    public class CreateOrderRequestModel
    {
        public string UserId { get; set; }
        public List<Item> Items { get; set; }
    }

    public class Item
    {
        public string BookId { get; set; }
        public int Amount { get; set; }
    }
}
