using System;
using System.Collections.Generic;
namespace MyBlog.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Details { get; set; }
        public DateTime CreatedOn { get; set; }
        public int PostId { get; set; }

        public virtual Post Post { get; set; }
    }
}