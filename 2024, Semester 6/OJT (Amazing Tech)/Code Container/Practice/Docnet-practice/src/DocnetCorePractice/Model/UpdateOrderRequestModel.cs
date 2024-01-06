namespace DocnetCorePractice.Model
{
    public class UpdateOrderRequestModel
    {
        public string OrderId { get; set; }

        public List<AddOrderItemRequest> AddItems { get; set; }

        public List<UpdateOrderItemRequest> UpdateItems { get; set; }

        public List<RemoveOrderItemRequest> RemoveItems { get; set; }
    }

    public class AddOrderItemRequest
    {
        public string CaffeId { get; set; }
        public int Volumn { get; set; }
    }

    public class UpdateOrderItemRequest
    {
        public string OrderItemId { get; set; }
        public int Volumn { get; set; }
    }

    public class RemoveOrderItemRequest
    {
        public string OrderItemId { get; set; }
    }

}
