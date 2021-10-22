using BlogProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Configurations
{
    public class ArticleConfigurations : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasOne(navigationExpression: m => m.User)
                .WithMany(navigationExpression: g => g.Articles)
                .HasForeignKey(s => s.UserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            builder.HasOne(m => m.Category)
               .WithMany(g => g.Articles)
               .HasForeignKey(s => s.CategoryId)
               .OnDelete(DeleteBehavior.Restrict)
               .IsRequired();
        }
    }
}
