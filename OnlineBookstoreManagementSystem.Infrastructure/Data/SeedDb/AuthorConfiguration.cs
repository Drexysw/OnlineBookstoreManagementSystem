using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineBookstoreManagementSystem.Infrastructure.Data.Models;

namespace OnlineBookstoreManagementSystem.Infrastructure.Data.SeedDb
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
           
            var data = new SeedData();
            builder.HasData(new Author[] { data.FirstAuthor, data.SecondAuthor, data.ThirdAuthor });
        }
    }
}
