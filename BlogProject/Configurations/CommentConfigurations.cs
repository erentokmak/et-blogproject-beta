using BlogProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Configurations
{
    public class CommentConfigurations : IEntityTypeConfiguration<Comment>
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
