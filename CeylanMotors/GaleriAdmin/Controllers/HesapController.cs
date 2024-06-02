using Microsoft.AspNetCore.Mvc;

namespace GaleriAdmin.Controllers
{
    public class HesapController : Controller
    {
       public IActionResult Index()
        {

            return View();
        }
        public IActionResult Login()
        {

            return View();
        }
    }
}
