
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

        public int ArticleId { get; set; }
        public virtual Article Article{ get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
    public class CommentEntityConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasOne(navigationExpression: m => m.Article)
                .WithMany(navigationExpression: g => g.Comments)
                .HasForeignKey(s => s.ArticleId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.HasOne(navigationExpression: m => m.User)
                   .WithMany(navigationExpression: g => g.Comments)
                   .HasForeignKey(s => s.UserId)
                   .OnDelete(DeleteBehavior.Restrict)
                   .IsRequired();
           
        }
    }
    
}
