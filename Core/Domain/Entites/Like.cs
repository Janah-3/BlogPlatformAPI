namespace Domain.Entites
{
    public class Like 
    {
        // Navigation properties
        public user User { get; set; }
        public Post Post { get; set; }
        public DateTime AddedAt { get; set; }
        // Foreign keys
        public string UserId { get; set; }
        public int PostId { get; set; }
       
    
    }
}