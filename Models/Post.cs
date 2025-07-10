using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPostApp.Models
{
    
    
        public class Post
        {
            public int PostId { get; set; }

            // Other properties...

            public int PostTypeId { get; set; }

            public PostType PostType { get; set; }
        }

    }


