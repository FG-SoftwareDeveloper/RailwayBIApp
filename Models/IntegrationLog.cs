using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class IntegrationLog
    {
        public Guid IntegrationLogId { get; set; }

        public string Endpoint { get; set; } = string.Empty;

        public string RequestPayload { get; set; } = string.Empty;

        public string ResponsePayload { get; set; } = string.Empty;

        public DateTime TimeStamp { get; set; }

        public string Status { get; set; } = string.Empty;

        public string Message { get; set; }

        public bool IsSuccess { get; set; }
    }
}
