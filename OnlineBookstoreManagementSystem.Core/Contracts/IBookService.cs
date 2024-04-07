using OnlineBookstoreManagementSystem.Core.Models.Book;
using OnlineBookstoreManagementSystem.Core.Models.Category;

namespace OnlineBookstoreManagementSystem.Core.Contracts
{
    public interface IBookService
    {
      public Task<IEnumerable<BookIndexServiceModel>> LastThreeBooksAsync();
      public Task<IEnumerable<AllBooksQueryModel>> AllBooksAsync();
      public Task<IEnumerable<CategoryViewModel>> AllCategoriesAsync();
      public Task<BookQueryServiceModel>AllAsync(
            string? category = null,
            string? searchTerm = null,
            BookSorting sorting = BookSorting.Newest,
            int currentPage = 1,
            int housesPerPage = 1);
    }
}
