using Microsoft.EntityFrameworkCore;
using OnlineBookstoreManagementSystem.Core.Contracts;
using OnlineBookstoreManagementSystem.Core.Models.Book;
using OnlineBookstoreManagementSystem.Infrastructure.Common;
using OnlineBookstoreManagementSystem.Infrastructure.Data.Models;
namespace OnlineBookstoreManagementSystem.Core.Services
{
    public class BookService : IBookService
    {
        private IRepository repository;
        public BookService(IRepository _repository)
        {
            repository = _repository;
        }
        public async Task<IEnumerable<BookIndexServiceModel>> LastThreeBooksAsync()
        {
            return await repository.AllReadOnly<Book>()
                .OrderByDescending(b => b)
                .Take(3)
                 .Select(b => new BookIndexServiceModel()
                 {
                     Id = b.Id,
                     Title = b.Title,
                     imageUrl = b.ImageUrl,
                 })
                 .ToListAsync();
        }
    }
}
