using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayBI.Models
{
    public class Notification
    {
        public Guid Id { get; set; }
        public string Channel { get; set; }            // "Email", "Webhook", "Slack"
        public string Target { get; set; }             // Address or URL
        public string Message { get; set; }
        public DateTime SentAt { get; set; }
        public bool Success { get; set; }
    }
}
