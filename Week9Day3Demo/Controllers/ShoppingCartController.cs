using Microsoft.AspNetCore.Mvc;

namespace Week9Day3Demo.Controllers
{
    public class ShoppingCartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CheckOut()
        {
            return View();
        }

        public IActionResult Payment()
        {
            return View();
        }

    }
}
