using System.ComponentModel.DataAnnotations;
using static OnlineBookstoreManagementSystem.Infrastructure.Data.Constants.DataConstants;
using static OnlineBookstoreManagementSystem.Core.Constants.MessageConstants;
namespace OnlineBookstoreManagementSystem.Core.Models.Category
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(BookCategoryNameMaxLenght, 
            MinimumLength = BookCategoryNameminLenght, 
            ErrorMessage = LenghtMessage)]
        public string Name { get; set; } = string.Empty;

    }
}
