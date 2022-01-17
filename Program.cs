using System;
using System.Linq;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new BlogDataContext();
            // var user = new User
            // {
            //     Name = "Mateus Nadal",
            //     Slug = "mateusnadal",
            //     Email = "mateus@nadal.com",
            //     Bio = "Software Engineer",
            //     Image = "http://localhost/image",
            //     PasswordHash = "1231231231231243"
            // };

            // var category = new Category
            // {
            //     Name = "Back-end",
            //     Slug = "backend"
            // };

            // var post = new Post()
            // {
            //     Author = user,
            //     Category = category,
            //     Body = "Hello Word!",
            //     Slug = "ef-core",
            //     Summary = "Learn EF Core",
            //     Title = "EF Core",
            //     CreateDate = DateTime.Now,
            //     LastUpdateDate = DateTime.Now
            // };

            // context.Posts.Add(post);
            // context.SaveChanges();

            // var posts = context.Posts.AsNoTracking().Include(x => x.Author).Include(x => x.Category).OrderBy(x => x.LastUpdateDate).ToList();

            // foreach (var post in posts)
            // {
            //     Console.WriteLine($"{post.Title} escrito por {post.Author?.Name} em {post.Category?.Name}");
            // }

            var post = context.Posts.Include(x => x.Author).Include(x => x.Category).OrderByDescending(x => x.LastUpdateDate).FirstOrDefault();
            post.Author.Name = "Mateus Nadal";

            context.Posts.Update(post);
            context.SaveChanges();
        }
    }
}
