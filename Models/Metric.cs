using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Metric
    {

        public Guid MetricId { get; set; }

        public string MetricName { get; set; } //Temperature, Speed, etc.

        public string Unit { get; set; } // e.g., seconds, bytes, count

        public string DataType { get; set; } // e.g., integer, float, string

        public Guid DataSourceId { get; set; } // Foreign key to DataSource

        public DataSource DataSource { get; set; } // Navigation property to DataSource

    }
}
