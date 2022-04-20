using Blog.Data;
using Blog.Models;

using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

using (var context = new BlogDataContext())
{
    // var tag = new Tag { Name = ".NET", Slug = "dotnet" };
    // context.Tags.Add(tag);
    // context.SaveChanges();

    // var tag2 = new Tag { Name = "ASP.NET", Slug = "aspnet" };
    // context.Tags.Add(tag2);
    // context.SaveChanges();

    var tag = context.Tags.AsNoTracking().FirstOrDefault(x => x.Id == 2);
    tag.Name = ".NET";
    tag.Slug = "dotnet";

    context.Update(tag);
    context.SaveChanges();

    // var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
    // context.Remove(tag);
    // context.SaveChanges();

    // var tags = context
    // .Tags
    // .AsNoTracking()
    // .ToList();

    // System.Console.WriteLine(tags);
    // foreach (var tag in tags)
    // {
    //     System.Console.WriteLine(tag.Name);
    // }

}