namespace Models
{
    public class Widget
    {
        public Guid WidgetId { get; set; } // Unique identifier for the widget
        public string Name { get; set; } // Name of the widget
        public string WidgetType { get; set; } // Type of widget (e.g., chart, gauge, table)
        public string Configuration { get; set; } // JSON or XML configuration for the widget
        public Guid DashboardId { get; set; } // Foreign key to the dashboard
        public Dashboard Dashboard { get; set; } // Navigation property to Dashboard
    }
}