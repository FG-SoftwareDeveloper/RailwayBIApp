using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayBI.Models
{
    public class TrackingDevice
    {
        public string DeviceId { get; set; } // e.g., "Truck-001"
        public string Label { get; set; } // Friendly name like "Fuel Truck 1"
        public string Status { get; set; } // "Online", "Offline", "Idle", etc.
        public DateTime LastActive { get; set; }
    }
}
