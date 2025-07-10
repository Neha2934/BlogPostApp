using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPostApp.Data
{
    using BlogPostApp.Models;
    using Microsoft.EntityFrameworkCore;
    using static System.Collections.Specialized.BitVector32;

    public class AppDbContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<BlogType> BlogTypes { get; set; }
        public DbSet<PostType> PostTypes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        =>
       options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BlogDb;Trusted_Connection = True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>()
                .HasOne(p => p.PostType)
                .WithMany(pt => pt.Posts)
                .HasForeignKey(p => p.PostTypeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
