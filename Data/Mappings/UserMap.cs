using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasColumnName("Name").HasColumnType("NVARCHAR").HasMaxLength(80);
            builder.Property(x => x.Bio);
            builder.Property(x => x.Email);
            builder.Property(x => x.Image);
            builder.Property(x => x.Name);
            builder.Property(x => x.PasswordHash);
            builder.HasIndex(x => x.Slug, "IX_Category_Slug").IsUnique();
            builder.HasIndex(x => x.Slug, "IX_User_Slug").IsUnique();
        }
    }
}
