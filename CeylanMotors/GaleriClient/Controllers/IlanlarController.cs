using Galeri.BLL.Managers.Concrete;
using Galeri.ViewModel.Category;
using Galeri.ViewModel.Picture;
using Microsoft.AspNetCore.Mvc;

namespace CeylanMotors.Controllers
{
    public class IlanlarController : Controller
    {
        private CategoryManager _categoryManager;
        private ImageManager _imageManager;

        public IlanlarController(CategoryManager categoryManager, ImageManager imageManager)
        {
            _categoryManager = categoryManager;
            _imageManager = imageManager;
        }

        public IActionResult Index()
        {
            IEnumerable<CategoryViewModel> list = _categoryManager.GetAll().ToList();
            IEnumerable<ImageViewModel> imageList = _imageManager.GetAll().ToList();

            ViewBag.ImageList = imageList;

            return View(list);
        }

    }
}
