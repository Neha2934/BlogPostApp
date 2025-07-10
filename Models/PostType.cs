using BlogPostApp.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class PostType
{
    public int PostTypeId { get; set; }

    public int Status { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    // Navigation property
    public ICollection<Post> Posts { get; set; }
}
