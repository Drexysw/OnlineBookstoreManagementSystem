using System.ComponentModel.DataAnnotations;
using static OnlineBookstoreManagementSystem.Core.Constants.MessageConstants;
using static OnlineBookstoreManagementSystem.Infrastructure.Data.Constants.DataConstants;
namespace OnlineBookstoreManagementSystem.Core.Models.Book
{
    public class AllBooksQueryModel
    {
        public const int BooksPerPage = 3;

        public string? Category { get; set; }

        public string? SearchTerm { get; set; }

        public BookSorting Sorting { get; set; }

        public int CurrentPage { get; set; } = 1;

        public int TotalBoardGamesCount { get; set; }

        public IEnumerable<string> Categories { get; set; } = Enumerable.Empty<string>();

        public IEnumerable<BooksAllServiceModel> Books { get; set; } = Enumerable.Empty<BooksAllServiceModel>();
    }
}
