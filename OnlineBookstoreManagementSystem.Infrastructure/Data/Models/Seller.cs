using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static OnlineBookstoreManagementSystem.Infrastructure.Data.Constants.DataConstants;
namespace OnlineBookstoreManagementSystem.Infrastructure.Data.Models
{
    public class Seller
    {
        [Key]
        [Comment("Seller's identifier")]
        public int Id { get; set; }
        [Required]
        [MaxLength(SellerNameMaxLengh)]
        [Comment("Seller's name")]
        public string Name { get; set; } = string.Empty;
        [Comment("Seller's rating")]
        public double Rating { get; set; }
        public IEnumerable<Book> Books { get; set; } = new List<Book>();
    }
}