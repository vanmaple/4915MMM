using Microsoft.EntityFrameworkCore;
using SDP_EntityModels;
using Project.Models;

namespace Project.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<Shipping> Shipping { get; set; }
        public DbSet<InventoryLog> InventoryLogs { get; set; }
        public DbSet<AfterSales> AfterSales { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}