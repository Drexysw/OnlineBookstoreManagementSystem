using System.ComponentModel.DataAnnotations;
using static OnlineBookstoreManagementSystem.Core.Constants.MessageConstants;
using static OnlineBookstoreManagementSystem.Infrastructure.Data.Constants.DataConstants;
namespace OnlineBookstoreManagementSystem.Core.Models.Book
{
    public class AllBooksQueryModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(TitleMaxLenght, MinimumLength = TitleMinLenght, ErrorMessage = LenghtMessage)]
        public string Title { get; set; } = string.Empty;
        [Required]
        [Display(Name = "Image URL")]
        public string imageUrl { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Price of the book")]
        [Range(BookPriceMinimumValue, BookPriceMaximumValue, ErrorMessage = PriceMessage)]
        public decimal Price { get; set; } 
    }
}
