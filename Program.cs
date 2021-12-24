using System;
using System.Threading.Tasks;
using Blog.Data;
using Blog.Models;

namespace efcore_overview
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new BlogDataContext();

            var tag = new Tag { Name = "ASP.NET", Slug = "ASP.NET" };
            context.Tags.Add(tag);
            context.SaveChanges();
        }
    }
}
