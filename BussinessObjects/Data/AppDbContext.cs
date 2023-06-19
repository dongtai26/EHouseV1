
using BussinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObjects.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("MyStoreDB"));
        }

        public virtual DbSet<Comment>? Comments { get; set; }
        public virtual DbSet<Contract>? Contracts { get; set; }
        public virtual DbSet<History>? Histories { get; set; }
        public virtual DbSet<HouseRent>? HouseRents { get; set; }
        public virtual DbSet<Image>? Images { get; set; }
        public virtual DbSet<Notification>? Notifications { get; set; }
        public virtual DbSet<Post>? Posts { get; set; }
        public virtual DbSet<Role>? Roles { get; set; }
        public virtual DbSet<User>? Users { get; set; }
        public virtual DbSet<Admin>? Admins { get; set; }
        public virtual DbSet<Lessee>? Lessees { get; set; }
        public virtual DbSet<Lessor>? Lessors { get; set; }
        public virtual DbSet<UserToken>? UserTokens { get; set; }



        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasNoKey();
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}
