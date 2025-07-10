using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPostApp.Models
{
    [Table("BlogType")]
    public class BlogType
    {
        public int BlogTypeId { get; set; }

        [Required]
        public int Status { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [MaxLength(400)]
        public string Description { get; set; }
    }
}

