namespace OnlineBookstoreManagementSystem.Infrastructure.Data.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public IEnumerable<Book> Books { get; set; } = new List<Book>();    
    }
}