using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayBI.Models
{
    public class TriggerRule
    {
        public Guid Id { get; set; }
        public string Name { get; set; }               // "Low Fuel", "Overspeed"
        public string ConditionType { get; set; }      // "FuelLevel", "Speed", etc.
        public double Threshold { get; set; }          // e.g., < 10%
        public string Comparison { get; set; }         // "LessThan", "GreaterThan", "Equals"
        public bool IsActive { get; set; }
    }
}
