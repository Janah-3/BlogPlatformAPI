

using System.ComponentModel.DataAnnotations;

namespace Shared.Dtos.PostDto
{
    public class CreatePostDto
    {
        [Required]
        public string Content { get; set; }

        public string CategoryName { get; set; }
        public List<string> Images { get; set; } = new();
        // Existing tags by ID
        public List<int> TagIds { get; set; } = new();

        // Optional: allow new tags to be added
        public List<string> NewTags { get; set; } = new();


    }
}
