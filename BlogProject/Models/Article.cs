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

        public string ArticleTitle { get; set; }
        public string ArticleSubject { get; set; }
        public string ArticleContent { get; set; }
        public DateTime ArticleAddTime { get; set; }
        public int ArticleViews { get; set; }

        public int UserId { get; set; }
        public virtual Users User { get; set; }

        public int CommentId { get; set; }
        public ICollection<Comment> Comments { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
    public class ArticlesEntityConfiguration : IEntityTypeConfiguration<Article>
    //Article tablosunda user foreign'i oluşturmaya çalışıyorum. // çalışıyor
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
