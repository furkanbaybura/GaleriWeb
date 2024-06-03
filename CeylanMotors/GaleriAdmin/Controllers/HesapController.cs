using Galeri.BLL.Managers.Concrete;
using Galeri.ViewModel.Category;
using Microsoft.AspNetCore.Mvc;

namespace GaleriAdmin.Controllers
{
    public class HesapController : Controller
    {
        private CategoryManager _categoryManager;

        public HesapController(CategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }
        public IActionResult Index()
        {
            IEnumerable<CategoryViewModel> list = _categoryManager.GetAll();

            return View(list);
           
        }
        public IActionResult Login()
        {

            return View();
        }
    }
}
