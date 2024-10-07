using Microsoft.AspNetCore.Mvc;

namespace CeylanMotors.Controllers
{
    public class HakkımızdaController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.resim ="./images/hakkimizda.png";
            return View();
        }
    }
}
