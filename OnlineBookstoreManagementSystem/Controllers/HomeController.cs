﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineBookstoreManagementSystem.Core.Contracts;
using OnlineBookstoreManagementSystem.Models;
using System.Diagnostics;
namespace OnlineBookstoreManagementSystem.Controllers
{
    public class HomeController : BaseController
    {
        public readonly ILogger<HomeController> Logger;
        public readonly IBookService bookService;
        public HomeController(
            ILogger<HomeController> _Logger,
            IBookService _bookService
            )
        {
            Logger = _Logger;
            bookService = _bookService;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var model = await bookService.LastThreeBooksAsync();

            return View(model);
        }
        [AllowAnonymous]

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
