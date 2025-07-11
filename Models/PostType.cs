using BlogPostApp.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace BlogPostApp.Models
{

    public class PostType
    {
        public int PostTypeId { get; set; }

        public int Status { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        // Navigation property
        public List<Post> Posts { get; set; }
    }
}
