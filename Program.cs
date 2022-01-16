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
            {
                //CREATE
                // var tag = new Tag { Name = ".NET", Slug = "dotnet" };
                // context.Tags.Add(tag);
                // context.SaveChanges();

                // UPDATE
                // var tag = context.Tags.FirstOrDefault(x => x.Id == 4);
                // tag.Name = "ASP.NET";
                // tag.Slug = "EF Core";
                // context.Update(tag);
                // context.SaveChanges();

                //DELETE
                // var tag = context.Tags.FirstOrDefault(x => x.Id == 3);
                // context.Tags.Remove(tag);
                // context.SaveChanges();

                // //GET
                // var tags = context.Tags.AsNoTracking().Where(x => x.Name.Contains(".NET")).ToList();

                // foreach (var tag in tags)
                // {
                //     Console.Write(tag.Name);
                // }

                var tag = context.Tags.AsNoTracking().FirstOrDefault(x => x.Id == 1);
                Console.WriteLine(tag?.Name);

            }
        }
    }
}
