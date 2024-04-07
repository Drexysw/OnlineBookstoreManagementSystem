using Microsoft.AspNetCore.Mvc;

namespace OnlineBookstoreManagementSystem.Controllers
{
    public class SellerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
