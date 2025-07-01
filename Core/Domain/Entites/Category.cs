namespace Domain.Entites
{
    public class Category : BaseEntity<int>
    {
        public string CategoryName { get; set; }

        // Navigation properties
        public ICollection<Post> posts { get; set; } = [];
    }
}