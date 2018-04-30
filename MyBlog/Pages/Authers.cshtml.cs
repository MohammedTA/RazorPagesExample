using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyBlog.Data;
using MyBlog.Models;

namespace MyBlog.Pages
{
	public class AuthersModel : PageModel
	{
		public BlogContext context;

		public AuthersModel(BlogContext context)
		{
			this.context = context;
		}

		public List<Author> Authors { get; set; }

		public void OnGet(int? id, string authorname)
		{
			var query = context.Authors.AsQueryable(); // select * from auther

			if (id.HasValue)
				query = query.Where(a => a.Id == id); // select * from auther where id = {id}


			if (!string.IsNullOrEmpty(authorname))
				query = query.Where(a => a.Name.Contains(authorname)); // select * from auther where name like '%{authorname}%'


			Authors = query.ToList();
		}

		public IActionResult OnPost(int id)
		{
			var auther = context.Authors.Find(id);

			if (auther != null)
			{
				context.Authors.Remove(auther);
				context.SaveChanges();
			}

			return RedirectToPage();
		}
	}
}