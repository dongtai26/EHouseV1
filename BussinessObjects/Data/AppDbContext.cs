
using BusinessObjects.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Data
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
        public virtual DbSet<PostImage>? PostImages { get; set; }
        public virtual DbSet<Notification>? Notifications { get; set; }
        public virtual DbSet<Post>? Posts { get; set; }
        public virtual DbSet<Role>? Roles { get; set; }
        public virtual DbSet<User>? Users { get; set; }
        public virtual DbSet<Admin>? Admins { get; set; }
        public virtual DbSet<Lessee>? Lessees { get; set; }
        public virtual DbSet<Lessor>? Lessors { get; set; }
        public virtual DbSet<UserToken>? UserTokens { get; set; }
        public virtual DbSet<Location>? Locations { get; set; }
        public virtual DbSet<HouseAddress>? HouseAddresses { get; set; }
        public virtual DbSet<HouseImage>? HouseImages { get; set; }
        public virtual DbSet<HouseRent>? HouseRents { get; set; }
        public virtual DbSet<Merchant>? Merchants { get; set; }
        public virtual DbSet<Payment>? Payments { get; set; }
        public virtual DbSet<PaymentDestination>? PaymentDestinations { get; set; }
        public virtual DbSet<PaymentNotification>? PaymentNotifications { get; set; }
        public virtual DbSet<PaymentSignature>? PaymentSignatures { get; set; }
        public virtual DbSet<PaymentTransaction>? PaymentTransactions { get; set; }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}
