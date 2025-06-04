using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayBI.Models
{
    public class AuditEntry
    {
        public Guid Id { get; set; }
        public string PerformedBy { get; set; } // username or system
        public string Action { get; set; } // e.g., "DEVICE_RENAMED", "LOGIN_SUCCESS"
        public string Target { get; set; } // what was affected
        public DateTime Timestamp { get; set; }
        public string? Notes { get; set; }
    }
}
