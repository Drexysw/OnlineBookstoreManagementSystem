using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineBookstoreManagementSystem.Core.Contracts;
using OnlineBookstoreManagementSystem.Core.Models.Book;
using OnlineBookstoreManagementSystem.Models;
using System.Diagnostics;

namespace OnlineBookstoreManagementSystem.Controllers
{
    public class BookController : BaseController
    {
        private readonly ILogger<BookController> logger;
        private readonly IBookService bookService;
        public BookController(ILogger<BookController> _logger, IBookService _bookService)
        {
            logger = _logger;
            bookService = _bookService;
        }
        [AllowAnonymous]
        public async Task<IActionResult> All([FromQuery]AllBooksQueryModel query)
        {
            var result = await bookService.AllAsync(
                query.Category,
                query.SearchTerm,
                query.Sorting,
                query.CurrentPage,
                AllBooksQueryModel.BooksPerPage);

            query.TotalBoardGamesCount = result.TotalBooksCount;
            query.Categories = await bookService.AllCategoriesNameAsync();
            query.Books = result.Books;

            return View(query);
        }
        
    }
}
