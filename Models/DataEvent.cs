using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class DataEvent
    {
        public Guid DataEventId { get; set; } // Unique identifier for the data event
        public DateTime Timestamp { get; set; } // Timestamp of the event
      
        public Metric Metric { get; set; } // Navigation property to Metric
        public Guid MetricId { get; set; } // Foreign key to Metric

        public decimal Value { get; set; } // The value of the metric at this event

        public bool IsSimulated { get; set; } // Indicates if the event is simulated
    }
}
