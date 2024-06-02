using Galeri.BLL.Managers.Concrete;
using Galeri.ViewModel.Category;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GaleriAdmin.Controllers
{
    public class CategoryController : Controller
    {
        private CategoryManager _categoryManager;

        public CategoryController(CategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }

        // GET: CategoryController
        public ActionResult Index()
        {

            IEnumerable<CategoryViewModel> list = _categoryManager.GetAll().ToList();

            return View(list);
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            CategoryViewModel? model = _categoryManager.Get(id);

            return View(model);
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            CategoryViewModel model = new CategoryViewModel();
            return View(model);
        }
        public ActionResult Login()
        {
            CategoryViewModel model = new CategoryViewModel();
            return View(model);
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoryViewModel model)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return View(model);
                }
                model.AppUserId = 1 ; 
               if( _categoryManager.Add(model)>0) 
                return RedirectToAction(nameof(Index));
               else
                {
                    ModelState.AddModelError("DbError","Veritabanına eklenemedi");
                    return View(model);
                }
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("GeneralException", ex.Message);
                return View();
            }
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            CategoryViewModel model = _categoryManager.Get(id);
            return View(model);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CategoryViewModel model, int id)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return View(model);
                }
                model.AppUserId=1 ;
                if (_categoryManager.Update(model)>0)
                    return RedirectToAction(nameof(Index));
                else
                {
                    ModelState.AddModelError("DbError","Veritabanına eklenemedi");
                    return View(model);
                }

                                
            }
            catch(Exception ex)
            {
                ModelState.AddModelError("GenerelException",ex.Message);
                return View();
            }
        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                _categoryManager.Delete(id);

            }
            catch (Exception ex)
            {

                return RedirectToAction(nameof(Index));
            }


            return RedirectToAction(nameof(Index));
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
