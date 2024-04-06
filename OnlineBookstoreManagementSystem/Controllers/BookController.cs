using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineBookstoreManagementSystem.Models;
using System.Diagnostics;

namespace OnlineBookstoreManagementSystem.Controllers
{
    public class BookController : BaseController
    {
        private readonly ILogger logger;
        public BookController(ILogger _logger)
        {
            logger = _logger;
        }
        
    }
}
