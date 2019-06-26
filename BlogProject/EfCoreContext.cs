﻿using Microsoft.EntityFrameworkCore;
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

        public DbSet<Category> Categories { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Article> Articles { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticlesEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CommentsEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CommentsUsersEntityConfiguration());
        }
    }
}
