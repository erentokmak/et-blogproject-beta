
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Models
{
    public class Comments
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public int ArticlesId { get; set; }
        public virtual Articles  Articles{ get; set; }

        public int UsersId { get; set; }
        public virtual Users Users { get; set; }
    }
    public class CommentsEntityConfiguration : IEntityTypeConfiguration<Comments>
    //Comments tablosunda Articles foreign'i oluşturmaya çalışıyorum. // çalışıyor
    {
        public void Configure(EntityTypeBuilder<Comments> builder)
        {
            builder.HasOne(navigationExpression: m => m.Articles)
                .WithMany(navigationExpression: g => g.ArticleComments)
                .HasForeignKey(s => s.ArticlesId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
        }
    }
    public class CommentsUsersEntityConfiguration : IEntityTypeConfiguration<Comments>
    //Comments tablosunda User foreign'i oluşturmaya çalışıyorum. // çalışıyor
    {
        public void Configure(EntityTypeBuilder<Comments> builder)
        {
            builder.HasOne(navigationExpression: m => m.Users)
                .WithMany(navigationExpression: g => g.Comments)
                .HasForeignKey(s => s.UsersId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
        }
    }
}
