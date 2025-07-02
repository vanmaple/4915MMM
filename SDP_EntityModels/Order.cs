namespace SDP_EntityModels
{
    public class Order
    {
        public int order_id { get; set; }
        public int customerID { get; set; }
        public int toy_id { get; set; }
        public int quantity { get; set; }
        public DateTime order_date { get; set; }
        public string Status { get; set; }
    }
}