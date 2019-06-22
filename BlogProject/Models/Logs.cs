using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Models
{
    public class Logs
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual Users User { get; set; }
        public DateTime EnterTime { get; set; }
        public DateTime ExitTime { get; set; }
    }
    public class LogsEntityConfiguration : IEntityTypeConfiguration<Logs>//Logs tablosunda user foreign'i oluşturmaya çalışıyorum. // çalışmıyor
    {
        public void Configure(EntityTypeBuilder<Logs> builder)
        {
            builder.HasOne<Users>(navigationExpression: l => l.User)
                .WithOne(navigationExpression: l => l.Logs)
                .HasForeignKey<Users>(l => l.LogsId);
        }
    }
}
