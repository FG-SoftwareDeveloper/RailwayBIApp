using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayBI.Models
{
    public class KPI
    {
        public string Title { get; set; }           // "Average Speed"
        public double Value { get; set; }           // 45.2
        public string Unit { get; set; }            // "MPH", "hrs", "%"
        public string Status { get; set; }          // "Normal", "Warning", "Critical"
        public DateTime LastUpdated { get; set; }
    }
}
