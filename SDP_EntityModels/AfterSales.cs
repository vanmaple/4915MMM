using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_EntityModels
{
    public class AfterSales
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Type { get; set; } 
        public string Status { get; set; } 
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
