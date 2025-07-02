﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_EntityModels
{
    public class Shipping
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string TrackingNumber { get; set; }
        public string Courier { get; set; }
        public string Status { get; set; } 
        public DateTime CreatedAt { get; set; }
    }
}
