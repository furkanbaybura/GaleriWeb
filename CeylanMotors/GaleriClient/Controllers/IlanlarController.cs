using Galeri.BLL.Managers.Concrete;
using Galeri.ViewModel.Category;
using Microsoft.AspNetCore.Mvc;

namespace CeylanMotors.Controllers
{
    public class IlanlarController : Controller
    {
        private CategoryManager _categoryManager;

        public IlanlarController(CategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }

        public IActionResult Index()
        {
            IEnumerable<CategoryViewModel> list = _categoryManager.GetAll().ToList();

            return View(list);
        }

    }
}
