using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogProject.Models;

namespace BlogProject
{
    public class EfCoreContext : DbContext

    {
        public EfCoreContext(DbContextOptions<EfCoreContext> options) : base(options)
        {    
        }

        public DbSet<Articles> Articles { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Comments> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticlesEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CommentsEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CommentsUsersEntityConfiguration());

        }

    }
}
