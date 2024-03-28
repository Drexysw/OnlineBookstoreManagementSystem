using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineBookstoreManagementSystem.Infrastructure.Data.Models;

namespace OnlineBookstoreManagementSystem.Infrastructure.Data.SeedDb
{
    public class SellerConfiguration : IEntityTypeConfiguration<Seller>
    {
        public void Configure(EntityTypeBuilder<Seller> builder)
        {
            var data = new SeedData();
            builder.HasData(new Seller[] {data.Seller});
        }
    }
}
