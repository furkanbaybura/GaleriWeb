using Galeri.BLL.Managers.Concrete;
using Galeri.ViewModel.Category;
using Galeri.ViewModel.Slider;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Galeri.ViewModel.Yakinda;


namespace GaleriAdmin.Controllers
{
    public class YakindaController : Controller
    {        
            private YakindaManager _yakindaManager;
            public YakindaController(YakindaManager yakindaManager)
            {
                 _yakindaManager = yakindaManager;
            }

            public IActionResult Index()
            {
                IEnumerable<YakindaViewModel> list = _yakindaManager.GetAll().ToList();


                return View(list);
            }
            public ActionResult Details(int id)
            {
                  YakindaViewModel? model = _yakindaManager.Get(id);

                return View(model);
            }
            [HttpGet]
            public ActionResult Create()
            {
                   YakindaViewModel model = new YakindaViewModel();
                return View(model);
            }
            public ActionResult Login()
            {
                   YakindaViewModel model = new YakindaViewModel();
                return View(model);
            }

            // POST: CategoryController/Create
            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Create(YakindaViewModel model)
            {
                try
                {
                    if (!ModelState.IsValid)
                    {
                        return View(model);
                    }
                    model.AppUserId = 1;
                    if (_yakindaManager.Add(model) > 0)
                        return RedirectToAction("Index", "Yakinda");
                    else
                    {
                        ModelState.AddModelError("DbError", "Veritabanına eklenemedi");
                        return View(model);
                    }
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("GeneralException", ex.Message);
                    return View();
                }
            }
            // GET: CategoryController/Edit/5
            public ActionResult Edit(int id)
            {
                     YakindaViewModel model = _yakindaManager.Get(id);
                return View(model);
            }

            // POST: CategoryController/Edit/5
            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Edit(YakindaViewModel model, int id)
            {
                try
                {
                    if (!ModelState.IsValid)
                    {
                        return View(model);
                    }
                    model.AppUserId = 1;
                    if (_yakindaManager.Update(model) > 0)
                        return RedirectToAction("Index", "Yakinda");
                    else
                    {
                        ModelState.AddModelError("DbError", "Veritabanına eklenemedi");
                        return View(model);
                    }


                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("GenerelException", ex.Message);
                    return View();
                }
            }

            // GET: CategoryController/Delete/5
            public ActionResult Delete(int id)
            {
                try
                {
                    _yakindaManager.Delete(id);

                }
                catch (Exception ex)
                {

                    return RedirectToAction("Index", "Yakinda");
                }


                return RedirectToAction("Index", "Yakinda");
            }

            // POST: CategoryController/Delete/5
            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Delete(int id, IFormCollection collection)
            {
                try
                {
                    return RedirectToAction("Index", "Yakinda");
                }
                catch
                {
                    return View();
                }
            }
     }
}
