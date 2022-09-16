using Microsoft.AspNetCore.Mvc;

namespace MVCExample.Controllers
{
    public class Login : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
