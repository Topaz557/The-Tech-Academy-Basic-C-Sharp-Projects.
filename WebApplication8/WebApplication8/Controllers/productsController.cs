using Microsoft.AspNetCore.Mvc;

namespace WebApplication8.Controllers
{
    public class productsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
