
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public int ArticlesId { get; set; }
        public virtual Article Article{ get; set; }

        public int UsersId { get; set; }
        public virtual Users Users { get; set; }
    }
    public class CommentsEntityConfiguration : IEntityTypeConfiguration<Comment>
    //Comments tablosunda Articles foreign'i oluşturmaya çalışıyorum. // çalışıyor
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasOne(navigationExpression: m => m.Article)
                .WithMany(navigationExpression: g => g.Comments)
                .HasForeignKey(s => s.ArticlesId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
        }
    }
    public class CommentsUsersEntityConfiguration : IEntityTypeConfiguration<Comment>
    //Comments tablosunda User foreign'i oluşturmaya çalışıyorum. // çalışıyor
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasOne(navigationExpression: m => m.Users)
                .WithMany(navigationExpression: g => g.Comments)
                .HasForeignKey(s => s.UsersId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
        }
    }
}
