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

        // Foreign key
        public int CategoryId { get; set; }
        public ICollection<Tag> Tags { get; set; }
    }
}
