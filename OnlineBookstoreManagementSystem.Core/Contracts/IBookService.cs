using OnlineBookstoreManagementSystem.Core.Models.Book;
using OnlineBookstoreManagementSystem.Core.Models.Category;

namespace OnlineBookstoreManagementSystem.Core.Contracts
{
    public interface IBookService
    {
      public Task<IEnumerable<BookServiceModel>> LastThreeBooksAsync();
      public Task<IEnumerable<BooksAllServiceModel>> AllBooksAsync();
      public Task<IEnumerable<BookCategoryServiceModel>> AllCategoriesAsync();
      public Task<BookQueryServiceModel>AllAsync(
            string? category = null,
            string? searchTerm = null,
            BookSorting sorting = BookSorting.Newest,
            int currentPage = 1,
            int housesPerPage = 1);
      public Task<IEnumerable<string>> AllCategoriesNameAsync();
    }
}
