using Galeri.BLL.Managers.Concrete;
using Galeri.Entities.Concrete;
using Galeri.ViewModel.Category;
using Galeri.ViewModel.Slider;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;

namespace GaleriAdmin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SliderController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private SliderManager _sliderManager;
        public SliderController(SliderManager sliderManager, IWebHostEnvironment webHostEnvironment)
        {
            _sliderManager = sliderManager;
            _webHostEnvironment = webHostEnvironment;
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
            ModelState.Remove("Id");
            ModelState.Remove("RowNum");
            model.AppUserId = 1;



            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (model.SliderImageUpload is not null)
            {
                var array = model.SliderImageUpload.FileName.Split('.');
                var withoutExtension = array[0];
                var extension = array[1];

                Guid guid = Guid.NewGuid();
                model.SliderImageName = $"{withoutExtension}_{guid}.{extension}";
                var konum = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads", model.SliderImageName);

                using (var akisOrtami = new FileStream(konum, FileMode.Create))
                {
                    model.SliderImageUpload.CopyTo(akisOrtami);
                }
            }
            _sliderManager.Add(model);
            return RedirectToAction("Index", "Slider");

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
            ModelState.Remove("Id");
            ModelState.Remove("RowNum");
            model.AppUserId = 1;

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var oldslider = _sliderManager.Get(id);

            if (oldslider is null)
            {
                return BadRequest("hata var");
            }

            if (model.SliderImageUpload is null)
            {
                model.SliderImageName = oldslider.SliderImageName;
            }
            else
            {
                var array = model.SliderImageUpload.FileName.Split('.');
                var withoutExtension = array[0];
                var extension = array[1];

                Guid guid = Guid.NewGuid();
                model.SliderImageName = $"{withoutExtension}_{guid}.{extension}";
                var konum = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads", model.SliderImageName);

                using (var akisOrtami = new FileStream(konum, FileMode.Create))
                {
                    model.SliderImageUpload.CopyTo(akisOrtami);
                }
            }

            oldslider.SliderImageName = model.SliderImageName;
            oldslider.Sliderad = model.Sliderad;
            oldslider.SliderBaslik=model.SliderBaslik;
            oldslider.SliderAciklama=model.SliderAciklama;
            _sliderManager.Update(oldslider);
            return RedirectToAction("Index", ("Slider"));
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

