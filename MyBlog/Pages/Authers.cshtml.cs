using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyBlog.Data;
using MyBlog.Models;

namespace MyBlog.Pages
{
    public class AuthersModel : PageModel
    {
        public List<Auther> Authers { get; set; }
        public BlogContext context;

        public AuthersModel(BlogContext context)
        {
            this.context = context;
        }

        public void OnGet()
        {
            this.Authers = this.context.Authers.ToList();
        }
    }
}