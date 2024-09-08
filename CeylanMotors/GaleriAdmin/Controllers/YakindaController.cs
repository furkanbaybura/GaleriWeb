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
            ModelState.Remove("Id");
            ModelState.Remove("RowNum");
            model.AppUserId = 1;



            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (model.YakindaImageUpload is not null)
            {
                var array = model.YakindaImageUpload.FileName.Split('.');
                var withoutExtension = array[0];
                var extension = array[1];

                Guid guid = Guid.NewGuid();
                model.YakindaImageName = $"{withoutExtension}_{guid}.{extension}";
                var konum = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads", model.YakindaImageName);

                using (var akisOrtami = new FileStream(konum, FileMode.Create))
                {
                    model.YakindaImageUpload.CopyTo(akisOrtami);
                }
            }
            _yakindaManager.Add(model);
            return RedirectToAction("Index", "Yakinda");
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
            ModelState.Remove("Id");
            ModelState.Remove("RowNum");
            model.AppUserId = 1;

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var oldslider = _yakindaManager.Get(id);

            if (oldslider is null)
            {
                return BadRequest("hata var");
            }

            if (model.YakindaImageUpload is null)
            {
                model.YakindaImageName = oldslider.YakindaImageName;
            }
            else
            {
                var array = model.YakindaImageUpload.FileName.Split('.');
                var withoutExtension = array[0];
                var extension = array[1];

                Guid guid = Guid.NewGuid();
                model.YakindaImageName = $"{withoutExtension}_{guid}.{extension}";
                var konum = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads", model.YakindaImageName);

                using (var akisOrtami = new FileStream(konum, FileMode.Create))
                {
                    model.YakindaImageUpload.CopyTo(akisOrtami);
                }
            }

            oldslider.YakindaImageName = model.YakindaImageName;
            oldslider.YakindaAd = model.YakindaAd;
            oldslider.YakindaBaslik = model.YakindaBaslik;
            oldslider.YakindaAciklama = model.YakindaAciklama;
           _yakindaManager.Update(oldslider);
            return RedirectToAction("Index", ("Yakinda"));
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
