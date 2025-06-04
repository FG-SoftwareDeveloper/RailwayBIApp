using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Dashboard
    {
        public Guid DashboardId { get; set; } // Unique identifier for the dashboard
        public string Name { get; set; } // Name of the dashboard
        
        public Guid UserId { get; set; } // Foreign key to the user who owns the dashboard

        public ICollection<Widget> Widgets { get; set; } = new List<Widget>(); // Collection of widgets on the dashboard
    }
}
