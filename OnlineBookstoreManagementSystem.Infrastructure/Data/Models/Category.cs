using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static OnlineBookstoreManagementSystem.Infrastructure.Data.Constants.DataConstants;
namespace OnlineBookstoreManagementSystem.Infrastructure.Data.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(BookCategoryNameMaxLenght)]
        [Comment("Category's book name")]
        public string Name { get; set; } = string.Empty;

        public IEnumerable<Book> Books { get; set; } = new List<Book>();    
    }
}