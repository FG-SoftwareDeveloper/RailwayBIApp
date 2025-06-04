using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayBI.Models
{
    public class DeviceStatus
    {
        public string DeviceId { get; set; }
        public bool IsConnected { get; set; }
        public DateTime LastReported { get; set; }
        public string Note { get; set; }
    }
}
