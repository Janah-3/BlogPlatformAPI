

namespace Domain.Entites
{
    public class PostImage
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
    
        // Navigation properties
        public Post Post { get; set; }
        // Foreign key
        public int PostId { get; set; }

       
    }
}
