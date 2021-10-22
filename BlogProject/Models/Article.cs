using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogProject.Models
{
    public class Article
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public DateTime AddTime { get; set; }
        public int View { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
    public class ArticleEntityConfiguration : IEntityTypeConfiguration<Article>
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
