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
    [Table("Articles")]
    public class Articles
    {
        public int Id { get; set; }

        public string ArticleTitle { get; set; }
        public string ArticleSubject { get; set; }
        public string ArticleContent { get; set; }
        public DateTime ArticleAddTime { get; set; }
        public int ArticleViews { get; set; }
        public string ArticleComment { get; set; }

        public int UserId { get; set; }
        public virtual Users User { get; set; }

    }
    public class ArticlesEntityConfiguration : IEntityTypeConfiguration<Articles>
        //Article tablosunda user foreign'i oluşturmaya çalışıyorum. // çalışıyor
    {
        public void Configure(EntityTypeBuilder<Articles> builder)
        {
            builder.HasOne(navigationExpression: m => m.User)
                .WithMany(navigationExpression: g => g.Articles)
                .HasForeignKey(s => s.UserId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();              
        }
    }
}
