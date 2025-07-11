using BlogPostSimpleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPostApp.Models
{
    public class Blog
    {
        public int BlogId { get; set; } // Primary Key
        public string Url { get; set; }
        public bool isPublic { get; set; }
        public List<Post> Posts { get; set; }

        // Foreign key and navigation property
        public int BlogTypeId { get; set; }
        public BlogType BlogType { get; set; }




    }
}
