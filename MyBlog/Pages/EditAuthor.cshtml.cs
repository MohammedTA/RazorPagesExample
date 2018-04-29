using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyBlog.Data;
using MyBlog.Models;

namespace MyBlog.Pages
{
	public class EditAuthorModel : PageModel
	{
		public BlogContext context;

		public EditAuthorModel(BlogContext context)
		{
			this.context = context;
		}
		[BindProperty]
		public Auther Author { get; set; }

		public void OnGet(int id)
		{
			Author = context.Authers.Find(id);
		}

		public IActionResult OnPost()
		{
			//context.Attach(Author).State = EntityState.Modified;
			context.Authers.Update(Author);
			context.SaveChanges();
			return RedirectToPage("/Authers");
		}
	}
}