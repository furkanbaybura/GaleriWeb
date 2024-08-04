using Galeri.BLL.Managers.Concrete;
using Galeri.ViewModel.Category;
using Galeri.ViewModel.Slider;
using Microsoft.AspNetCore.Mvc;

namespace CeylanMotors.Controllers
{
    public class ReferenceController : Controller
    {
        private readonly ILogger<ReferenceController> _logger;
        private CategoryManager _categoryManager;
        private SliderManager _sliderManager;

        public ReferenceController(ILogger<ReferenceController> logger, CategoryManager categoryManager, SliderManager slidermanager)
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
    }
}
