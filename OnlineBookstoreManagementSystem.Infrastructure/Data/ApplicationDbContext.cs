using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineBookstoreManagementSystem.Infrastructure.Data.Models;
using System.Runtime.CompilerServices;

namespace OnlineBookstoreManagementSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Order>()
                .HasKey(o => new { o.BuyerId, o.BookId });

            builder.Entity<Order>()
                .HasOne(o => o.Book)
                .WithMany(o => o.Orders)
                .OnDelete(DeleteBehavior.Restrict);
            base.OnModelCreating(builder);
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Book> Books { get; set; } 
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Author> Authors { get; set; } 
    }
}
