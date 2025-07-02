using System;

namespace SDP_EntityModels
{
    public class ProcurementOrder
    {
        public int order_id { get; set; }

        public int material_name { get; set; }
        public string status { get; set; }
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; } 
    }
}
