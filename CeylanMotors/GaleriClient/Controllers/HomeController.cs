using Galeri.BLL.Managers.Concrete;
using Galeri.ViewModel.Category;
using GaleriClient.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GaleriClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private CategoryManager _categoryManager;

        public HomeController(ILogger<HomeController> logger, CategoryManager categoryManager)
        {
            _logger = logger;
            _categoryManager = categoryManager;
        }

        public IActionResult Index()
        {
            IEnumerable<CategoryViewModel> list = _categoryManager.GetAll().ToList();

            return View(list);
        }

        public IActionResult Ilanlar()
        {
            return View();
        }
        public IActionResult Hakkýmýzda()
        {
            ViewBag.resim = "./images/anadol.jpg";
            return View();
        }
        public IActionResult Iletisim()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

