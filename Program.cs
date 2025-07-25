﻿using BlogPostSimpleApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        using var context = new AppDbContext();


        var users = new List<User>
        {
            new User { Name = "Neha", Email = "Nehae@example.com", PhoneNumber = "2468631236" },
            new User { Name = "Kartik", Email = "Kartik@example.com", PhoneNumber = "9875434598" },
            new User { Name = "Parteek", Email = "Parteek@example.com", PhoneNumber = "3321733453" }
        };

        context.users.AddRange(users);
        try
        {
            context.SaveChanges();
        }
        catch (DbUpdateException ex)
        {
            Console.WriteLine("DB Update Exception: " + ex.Message);
            if (ex.InnerException != null)
            {
                Console.WriteLine("Inner Exception: " + ex.InnerException.Message);
            }
        }


        Console.Write("Enter blog URL: ");
        var url = Console.ReadLine();
        var blog = new Blog { Url = url };
        context.Blogs.Add(blog);
        context.SaveChanges();


        var user = context.users.First();
        var post = new Post
        {
            Title = "Hello Entity Framework",
            Content = "This is my firt Assignment!",
            BlogId = blog.BlogId,
            UserId = user.UserId,
            PostTypeId = 1
        };

        context.Posts.Add(post);
        context.SaveChanges();


        var blogs = context.Blogs
                           .Include(b => b.Posts)
                           .ThenInclude(p => p.User)
                           .ToList();

        foreach (var b in blogs)
        {
            Console.WriteLine($"Blog: {b.Url}");
            foreach (var p in b.Posts)
            {
                Console.WriteLine($"  Post: {p.Title} - {p.Content} (by {p.User?.Name ?? "Unknown"})");
            }
        }
    }
}