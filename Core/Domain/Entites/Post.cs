using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entites
{
    public class Post : BaseEntity<int>
    {

        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
       
        
        // Navigation properties
        public Category Category { get; set; }
        public ICollection<PostImage> PostImages { get; set; } = new List<PostImage>();
        public ICollection<Tag> Tags { get; set; }
         
        // Foreign key
        public int CategoryId { get; set; }
       
    }
}
