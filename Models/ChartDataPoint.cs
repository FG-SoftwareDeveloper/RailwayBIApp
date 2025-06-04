using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayBI.Models
{
    public class ChartDataPoint
    {
        public DateTime Timestamp { get; set; }
        public double Value { get; set; }
        public string SeriesLabel { get; set; }     // optional: "Fuel Level", "Speed"
    }
}
