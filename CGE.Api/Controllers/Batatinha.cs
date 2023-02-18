using Microsoft.AspNetCore.Mvc;

namespace CGE.Api.Controllers
{
    public class Batatinha : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
