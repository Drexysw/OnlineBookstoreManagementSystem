using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OnlineBookstoreManagementSystem.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
    }
}
