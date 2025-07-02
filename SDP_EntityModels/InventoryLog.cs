namespace SDP_EntityModels
{
    public class InventoryLog
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ChangeAmount { get; set; }
        public string Reason { get; set; }
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
