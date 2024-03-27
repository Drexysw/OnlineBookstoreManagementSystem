using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static OnlineBookstoreManagementSystem.Infrastructure.Data.Constants.DataConstants;
namespace OnlineBookstoreManagementSystem.Infrastructure.Data.Models
{
    public class Book
    {
        [Key]
        [Comment("Book Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLenght)]
        [Comment("Book Title")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MaxLength(DescriptionMaxLenght)]
        [Comment("Book Description")]
        public string Description { get; set; } = string.Empty;

        [Required]
        //[Range(typeof(decimal), BookPriceMinimumValue, BookPriceMaximumValue, ConvertValueInInvariantCulture = true)]
        [Comment("Price of the book")]
        public decimal Price { get; set; }

        [Required]
        [Comment("House image url")]
        public string ImageUrl = string.Empty;

        [Required]
        public int AuthorId { get; set; }

        [ForeignKey(nameof(AuthorId))]
        public Author Author { get; set; } = null!;

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;
       
        [Required]
        public int SellerId { get; set; }

        [ForeignKey(nameof(SellerId))]
        public Seller Seller { get; set; } = null!;

        public string? BuyerId { get; set; }

        public IEnumerable<Order> Orders { get; set; } = new List<Order>();

    }
}
