using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayBI.Models
{
    public class Alert
    {
        public Guid Id { get; set; }
        public string DeviceId { get; set; }
        public string RuleName { get; set; }           // Match to TriggerRule.Name
        public string Severity { get; set; }           // "Warning", "Critical"
        public string Message { get; set; }            // "Fuel level below 10%"
        public DateTime Timestamp { get; set; }
        public bool Acknowledged { get; set; }

    }
}
