using Microsoft.EntityFrameworkCore;
using FirstWebMVC.Models.Entities;
using FirstWebMVC.Models;
namespace FirstWebMVC.Data


{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Export> Exports { get; set; } 

public DbSet<ExportDetail> ExportDetails { get; set; } 
public DbSet<Import> Imports { get; set; } // bảng nhập kho
public DbSet<ImportDetail> ImportDetails { get; set; } // chi tiết nhập

public DbSet<Device> Devices { get; set; } // bảng thiết bị
    }
}