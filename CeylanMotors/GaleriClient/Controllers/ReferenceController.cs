using Microsoft.AspNetCore.Mvc;

namespace CeylanMotors.Controllers
{
    public class ReferenceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
