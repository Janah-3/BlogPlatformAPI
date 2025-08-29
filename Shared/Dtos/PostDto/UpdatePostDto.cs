

namespace Shared.Dtos.PostDto
{
    public class UpdatePostDto
    {
        public string? Content { get; set; }
        public List<string>? NewImages { get; set; } // optional new uploads
        public List<string>? ImageUrlsToRemove { get; set; } // optional delete
    }

}
