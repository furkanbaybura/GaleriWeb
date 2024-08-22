using Galeri.BLL.Managers.Concrete;
using Galeri.Entities.Concrete;
using Galeri.ViewModel.Category;
using Galeri.ViewModel.Slider;
using Galeri.ViewModel.Yakinda;
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
        private YakindaManager _yakindaManager;

        public HomeController(ILogger<HomeController> logger, CategoryManager categoryManager,SliderManager slidermanager , YakindaManager yakindaManager)
        {
            _logger = logger;
            _categoryManager = categoryManager;
            _sliderManager = slidermanager;
            _yakindaManager = yakindaManager;

        }

        public IActionResult Index()
        {
            IEnumerable<CategoryViewModel> list = _categoryManager.GetAll().ToList();
            IEnumerable<SliderViewModel> sliderlist = _sliderManager.GetAll().ToList();
            IEnumerable<YakindaViewModel> yakinda = _yakindaManager.GetAll().ToList();
            ViewBag.Yakinda=yakinda;
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

