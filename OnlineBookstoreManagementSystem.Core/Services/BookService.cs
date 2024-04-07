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

        public async Task<BookQueryServiceModel> AllAsync([FromQuery]string? category = null, 
            string? searchTerm = null, 
            BookSorting sorting = BookSorting.Newest, 
            int currentPage = 1, 
            int booksperpage = 1)
        {
            var books = repository.AllReadOnly<Book>();
            var result = new BookQueryServiceModel();
            if (string.IsNullOrEmpty(category) == false)
            {
                books = books.Where(b => b.Category.Name == category);
            }
            if (string.IsNullOrEmpty(searchTerm) == false)
            {
                books = books.Where(b => EF.Functions.Like(b.Title.ToLower(), searchTerm.ToLower()));
            }
            books = sorting switch
            {
                BookSorting.Price => books.OrderBy(b => b.Price),
                _ => books.OrderBy(b => b.Id)
            };
             result.Books =await  books
                .Skip((currentPage - 1) * booksperpage)
                .Take(booksperpage)
                .Select(b => new AllBooksQueryModel()
                {
                    Id = b.Id,
                    Title = b.Title,
                    imageUrl = b.ImageUrl,
                    Price = b.Price
                })
                .ToListAsync();
            result.TotalBooksCount = await books.CountAsync();
            return result;
        }

        public async Task<IEnumerable<AllBooksQueryModel>> AllBooksAsync()
        {
           return await repository.AllReadOnly<Book>()
                .OrderBy(b => b.Id)
                .Select(b => new AllBooksQueryModel()
                {
                    Id = b.Id,
                    Title = b.Title,
                    imageUrl = b.ImageUrl,
                    Price = decimal.Parse(b.Price.ToString("f2")),
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<CategoryViewModel>> AllCategoriesAsync()
        {
            return await repository.AllReadOnly<Category>()
                .OrderBy(b => b.Name)
                .Select(b => new CategoryViewModel()
                {
                    Id = b.Id,
                    Name = b.Name,
                })
                .ToListAsync();
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
