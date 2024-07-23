using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
