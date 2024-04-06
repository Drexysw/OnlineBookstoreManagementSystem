using OnlineBookstoreManagementSystem.Core.Models.Book;

namespace OnlineBookstoreManagementSystem.Core.Contracts
{
    public interface IBookService
    {
      public Task<IEnumerable<BookIndexServiceModel>> LastThreeBooksAsync();
    }
}
