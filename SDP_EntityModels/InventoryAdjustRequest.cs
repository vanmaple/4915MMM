using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_EntityModels
{
    public class InventoryAdjustRequest
    {
        public int ProductId { get; set; }
        public int AdjustAmount { get; set; }
        public string Reason { get; set; }
    }
}
