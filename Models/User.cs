namespace RailwayBI.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public List<string> Roles { get; set; } = new();
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        // Additional properties can be added as needed

        public ICollection<UserRole> UserRoles { get; set; } 
    }
}