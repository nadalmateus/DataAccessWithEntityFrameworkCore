using Blog.Data;

Console.WriteLine("Hello, World!");

using (var context = new BlogDataContext())
{
    // var tag = new Tag { Name = "ASP.NET", Slug = "aspnet" };
    // context.Tags.Add(tag);
    // context.SaveChanges();

    var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
    tag.Name = ".NET";
    tag.Slug = "dotnet";
    context.Update(tag);
    context.SaveChanges();
}