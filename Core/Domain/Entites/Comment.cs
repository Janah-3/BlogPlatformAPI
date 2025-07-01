namespace Domain.Entites
{
    public class Comment : BaseEntity<int>
    {
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // Navigation properties
        public user User { get; set; }
        public Post Post { get; set; }

        // Foreign keys
        public string UserId { get; set; }
        public int PostId { get; set; }
        // Additional properties can be added here if needed
    
    }
}