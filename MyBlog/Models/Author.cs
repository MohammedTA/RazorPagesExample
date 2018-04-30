using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MyBlog.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Post> Posts { get; set; }

    }
}