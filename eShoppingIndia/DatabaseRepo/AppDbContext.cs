using Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Repository
{
    public class AppDbContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {   }
      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
           
            base.OnModelCreating(modelBuilder);
           

        }


    }
}
