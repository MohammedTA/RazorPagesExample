using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MyBlog.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? CategoryId { get; set; }
        public int AutherId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Auther Auther { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
