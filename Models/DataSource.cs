using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class DataSource
    {
        public Guid DataSourceId { get; set; }
        public string Name { get; set; }

        public string Type { get; set; } // e.g., SQL, NoSQL, API

        public string ConnectionString { get; set; } // Connection string or API endpoint

        public bool IsSimulated { get; set; } // Indicates if the data source is simulated


    }
}
