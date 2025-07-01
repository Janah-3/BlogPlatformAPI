using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entites
{
    public class user : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        // Navigation properties can be added here if needed
        // public virtual ICollection<OtherEntity> OtherEntities { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Like> Likes { get; set; }

    }
}
