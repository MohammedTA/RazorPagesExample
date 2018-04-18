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
    public class CategoriesModel : PageModel
    {
        private readonly BlogContext _context;
        public List<Category> Categories { get; set; }

        public CategoriesModel(BlogContext context)
        {
            this._context = context;
        }
        public void OnGet()
        {
            this.Categories = this._context.Categories.ToList();
        }
    }
}