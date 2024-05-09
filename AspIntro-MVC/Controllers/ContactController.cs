using Microsoft.AspNetCore.Mvc;

namespace AspIntro_MVC.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
