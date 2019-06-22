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
    public class Users
    {

        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string UserMail { get; set; }
        public string UserBirth { get; set; }
        public string UserGender { get; set; }
        public string UserPhone { get; set; }

        public int ArticlesId { get; set; }
        public ICollection<Articles>Articles { get; set; }

        public int LogsId { get; set; }
        public virtual Logs Logs { get; set; }
    }
    public class UsersEntityConfiguration : IEntityTypeConfiguration<Users>
        //User tablosunda logs foreign'i oluşturmaya çalışıyorum. // aslında bunun olmaması lazım fakat build hatası alıyorum
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.HasOne<Logs>(navigationExpression: l => l.Logs)
                .WithOne(navigationExpression: u => u.User)
                .HasForeignKey<Logs>(u => u.UserId);  
        }     
    }
}
