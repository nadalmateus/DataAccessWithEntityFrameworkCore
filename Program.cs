using System;
using System.Linq;
using Blog.Data;
using Blog.Models;

namespace Blog
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using var context = new BlogDataContext();

            // context.Users.Add(new User
            // {
            //     Bio = "Software Engineer",
            //     Email = "mateus@nadal.com",
            //     Image = "https://localhost/image",
            //     Name = "Mateus Nadal",
            //     PasswordHash = "123123123123123",
            //     Slug = "mateusnadal"
            // });
            // context.SaveChanges();

            var user = context.Users.FirstOrDefault();
            var post = new Post
            {
                Author = user,
                Body = ".NET",
                Category = new Category
                {
                    Name = "Back-end",
                    Slug = "backend"
                },
                CreateDate = DateTime.Now,
                Slug = "dotnet",
                Summary = "Learn .NET",
                Title = ".NET",
            };
            context.Posts.Add(post);
            context.SaveChanges();
        }
    }
}
