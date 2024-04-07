using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineBookstoreManagementSystem.Core.Contracts;
using OnlineBookstoreManagementSystem.Core.Models.Book;
using OnlineBookstoreManagementSystem.Core.Models.Category;
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

        public async Task<BookQueryServiceModel> AllAsync([FromQuery] string? category = null,
            string? searchTerm = null,
            BookSorting sorting = BookSorting.Newest,
            int currentPage = 1,
            int booksperpage = 1)
        {
            var booksToShow = repository.AllReadOnly<Book>();
            var result = new BookQueryServiceModel();
            if (string.IsNullOrEmpty(category) == false)
            {
                booksToShow = booksToShow.Where(b => b.Category.Name == category);
            }
            if (string.IsNullOrEmpty(searchTerm) == false)
            {
                string normalizedSearchTerm = searchTerm.ToLower();
                booksToShow = booksToShow.Where(b => b.Title.ToLower().Contains( normalizedSearchTerm)||
                                                              b.Description.ToLower().Contains(normalizedSearchTerm));
            }
            booksToShow = sorting switch
            {
                BookSorting.Price => booksToShow.OrderBy(b => b.Price)
                                                .ThenBy(b => b.Title),
                _ => booksToShow.OrderBy(b => b.Id)
            };
             result.Books = await booksToShow
                .Skip((currentPage - 1) * booksperpage)
                .Take(booksperpage)
                .Select(b => new BooksAllServiceModel()
                {
                    Id = b.Id,
                    Title = b.Title,
                    ImageUrl = b.ImageUrl,
                    Price = b.Price
                })
                .ToListAsync();
            result.TotalBooksCount = await booksToShow.CountAsync();
            return result;
        }

        public async Task<IEnumerable<BooksAllServiceModel>> AllBooksAsync()
        {
           return await repository.AllReadOnly<Book>()
                .OrderBy(b => b.Id)
                .Select(b => new BooksAllServiceModel()
                {
                    Id = b.Id,
                    Title = b.Title,
                    ImageUrl = b.ImageUrl,
                    Price = decimal.Parse(b.Price.ToString("f2")),
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<BookCategoryServiceModel>> AllCategoriesAsync()
        {
            return await repository.AllReadOnly<Category>()
                .OrderBy(b => b.Name)
                .Select(b => new BookCategoryServiceModel()
                {
                    Id = b.Id,
                    Name = b.Name,
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<string>> AllCategoriesNameAsync()
        {
             return await repository.AllReadOnly<Category>()
                .Select(c => c.Name)
                .Distinct()
                .ToListAsync();
        }

        public async Task<IEnumerable<BookServiceModel>> LastThreeBooksAsync()
        {
            return await repository.AllReadOnly<Book>()
                .OrderByDescending(b => b)
                .Take(3)
                 .Select(b => new BookServiceModel()
                 {
                     Id = b.Id,
                     Title = b.Title,
                     ImageUrl = b.ImageUrl,
                 })
                 .ToListAsync();
        }
    }
}
