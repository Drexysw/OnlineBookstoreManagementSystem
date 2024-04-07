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
        private readonly ILogger logger;
        private readonly IBookService bookService;
        public BookController(ILogger _logger, IBookService _bookService)
        {
            logger = _logger;
            bookService = _bookService;
        }
        
        public async Task<IActionResult> All([FromQuery]AllBooksQueryModel query)
        {
            var model = await bookService.AllBooksAsync();
            return View(model);
        }
        
    }
}
