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
    public class CreateCategoryModel : PageModel
    {
        private readonly BlogContext _context;

        [BindProperty]
        public Category Category { get; set; }

        public CreateCategoryModel(BlogContext context)
        {
            this._context = context;
        }
        public void OnGet()
        {
            this.Category = new Category();
        }

        public IActionResult OnPost()
        {
           this._context.Categories.Add(this.Category);
            this._context.SaveChanges();

            return RedirectToPage("./Categories");
        }
    }
}