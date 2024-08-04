using Galeri.BLL.Managers.Concrete;
using Galeri.ViewModel.Category;
using Galeri.ViewModel.Slider;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GaleriAdmin.Controllers
{
    
    public class SliderController : Controller
    {
        private SliderManager _sliderManager;
        public SliderController(SliderManager sliderManager)
        {
            _sliderManager = sliderManager;
        }

        public IActionResult Index()
        {
            IEnumerable<SliderViewModel> list = _sliderManager.GetAll().ToList();
            

            return View(list);
        }
        public ActionResult Details(int id)
        {
            SliderViewModel? model = _sliderManager.Get(id);

            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            SliderViewModel model = new SliderViewModel();
            return View(model);
        }
        public ActionResult Login()
        {
            SliderViewModel model = new SliderViewModel();
            return View(model);
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SliderViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                model.AppUserId = 1;
                if (_sliderManager.Add(model) > 0)
                    return RedirectToAction("Index", "Slider");
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
            SliderViewModel model = _sliderManager.Get(id);
            return View(model);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SliderViewModel model, int id)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                model.AppUserId = 1;
                if (_sliderManager.Update(model) > 0)
                    return RedirectToAction("Index", "Slider");
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
                _sliderManager.Delete(id);

            }
            catch (Exception ex)
            {

                return RedirectToAction("Index", "Slider");
            }


            return RedirectToAction("Index", "Slider");
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction("Index", "Slider");
            }
            catch
            {
                return View();
            }
        }
    }
}

