﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyBlog.Data;
using MyBlog.Models;

namespace MyBlog.Pages
{
    public class CreateAuthorModel : PageModel
    {
        public BlogContext context;
        [BindProperty]
        public Auther Author { get; set; }

        public CreateAuthorModel(BlogContext context)
        {
            this.context = context;
        }
        public void OnGet()
        {
            this.Author = new Auther();
        }

        public IActionResult OnPost()
        {
            this.context.Authers.Add(this.Author);
            this.context.SaveChanges();

            return RedirectToPage("./Authers");

        }
    }
}