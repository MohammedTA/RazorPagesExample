using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyBlog.Models;

namespace MyBlog.Data
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().ToTable("Post");
            modelBuilder.Entity<Author>().ToTable("Auther");
            modelBuilder.Entity<Comment>().ToTable("Comment");
            modelBuilder.Entity<Category>().ToTable("Category");

            modelBuilder.Entity<Post>().HasKey(e => e.Id);

            modelBuilder.Entity<Post>().HasOne(t => t.Category)
                .WithMany(t => t.Posts)
                .HasForeignKey(t => t.CategoryId);

            modelBuilder.Entity<Post>().HasOne(t => t.Author)
                .WithMany(t => t.Posts)
                .HasForeignKey(t => t.AutherId);

            modelBuilder.Entity<Author>().HasKey(e => e.Id);
            modelBuilder.Entity<Comment>().HasKey(e => e.Id);

            modelBuilder.Entity<Comment>().HasOne(t => t.Post)
                .WithMany(t => t.Comments)
                .HasForeignKey(t => t.PostId);

            modelBuilder.Entity<Category>().HasKey(e => e.Id);
        }
    }
}
