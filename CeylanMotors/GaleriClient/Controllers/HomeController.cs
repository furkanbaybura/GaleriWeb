using Galeri.BLL.Managers.Concrete;
using Galeri.ViewModel.Category;
using Galeri.ViewModel.Slider;
using GaleriClient.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GaleriClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private CategoryManager _categoryManager;
        private SliderManager _sliderManager;

        public HomeController(ILogger<HomeController> logger, CategoryManager categoryManager,SliderManager slidermanager)
        {
            _logger = logger;
            _categoryManager = categoryManager;
            _sliderManager = slidermanager;
        }

        public IActionResult Index()
        {
            IEnumerable<CategoryViewModel> list = _categoryManager.GetAll().ToList();
            IEnumerable<SliderViewModel> sliderlist = _sliderManager.GetAll().ToList();
            ViewBag.List = sliderlist;
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

