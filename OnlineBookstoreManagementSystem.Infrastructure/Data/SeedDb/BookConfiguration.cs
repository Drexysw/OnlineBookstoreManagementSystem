﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineBookstoreManagementSystem.Infrastructure.Data.Models;

namespace OnlineBookstoreManagementSystem.Infrastructure.Data.SeedDb
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder
                .HasOne(h => h.Category)
                .WithMany(c => c.Books)
                .HasForeignKey(h => h.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(h => h.Seller)
                .WithMany(a => a.Books)
                .HasForeignKey(h => h.SellerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.
                HasOne(b => b.Author)
                .WithMany(c => c.Books)
                .HasForeignKey(h => h.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);
            var data = new SeedData();
            builder.HasData(new Book[] { data.FirstBook, data.SecondBook, data.ThirdBook });
        }
    }
}
