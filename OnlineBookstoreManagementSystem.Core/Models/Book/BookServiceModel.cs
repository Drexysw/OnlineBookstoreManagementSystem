using System.ComponentModel.DataAnnotations;
using static OnlineBookstoreManagementSystem.Core.Constants.MessageConstants;
using static OnlineBookstoreManagementSystem.Infrastructure.Data.Constants.DataConstants;
namespace OnlineBookstoreManagementSystem.Core.Models.Book
{
    public class BookServiceModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(TitleMaxLenght, MinimumLength =TitleMinLenght, ErrorMessage = LenghtMessage)]
        public string Title { get; set; } = string.Empty;
        [Required]
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; } = string.Empty;
    }
}
