using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class HistoricalLog
    {
        public Guid LogId { get; set; } // Unique identifier for the log entry

        public string LogName { get; set; }

        public string LogType { get; set; } // Type of log (e.g., error, info, debug)

        public string LogDescription { get; set; }

        public DateTime Timestamp { get; set; } // Timestamp of the log entry

        public Guid UserId { get; set; } // Foreign key to the user who created the log entry

        public ICollection<DataEvent> DataEvents { get; set; } = new List<DataEvent>(); // Collection of data events associated with the log entry
    }
}
