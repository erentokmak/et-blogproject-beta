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
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string UserMail { get; set; }
        public DateTime UserBirth { get; set; }
        public string UserGender { get; set; }
        public string UserPhone { get; set; }

        public int ArticlesId { get; set; }
        public ICollection<Articles>Articles { get; set; }

        public int CommentsId { get; set; }
        public ICollection<Comments> Comments { get; set; }
    }

    public enum Gender
    {
        Erkek,
        Kadın
    }
   
}
