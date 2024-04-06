using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OnlineBookstoreManagementSystem.Infrastructure.Data.Constants.DataConstants;
using static OnlineBookstoreManagementSystem.Core.Constants.MessageConstants;
namespace OnlineBookstoreManagementSystem.Core.Models.Book
{
    public class BookIndexServiceModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(TitleMaxLenght, MinimumLength =TitleMinLenght, ErrorMessage = LenghtMessage)]
        public string Title { get; set; } = string.Empty;
        [Required]
        [Display(Name = "Image URL")]
        public string imageUrl { get; set; } = string.Empty;
        [Required]
        [Range(BookPriceMinimumValue,BookPriceMaximumValue, ErrorMessage = PriceMessage)]
        public decimal Price { get; set; }
    }
}
