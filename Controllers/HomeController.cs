using Microsoft.AspNetCore.Mvc;

namespace HexaShopF.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
