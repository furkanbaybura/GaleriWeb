using Galeri.BLL.Managers.Concrete;
using Galeri.ViewModel.Category;
using Galeri.ViewModel.Slider;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;

namespace GaleriAdmin.Controllers
{
    
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
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                model.AppUserId = 1;

                if (model.SliderImageUpload != null && model.SliderImageUpload.Count > 0)
                {
                    model.SliderImage = new List<string>();

                    foreach (var file in model.SliderImageUpload)
                    {
                        if (file != null && file.Length > 0)
                        {
                            // Benzersiz bir dosya adı oluşturun
                            var fileName = Path.GetFileNameWithoutExtension(file.FileName);
                            var extension = Path.GetExtension(file.FileName);
                            var uniqueFileName = $"{fileName}_{Guid.NewGuid()}{extension}";

                            // Dosya kaydetme yolu
                            var uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "uploads");
                            var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                            // Dosyayı kaydet
                            using (var fileStream = new FileStream(filePath, FileMode.Create))
                            {
                                file.CopyTo(fileStream);
                            }

                            // Kaydedilen dosyanın yolunu veya URL'sini sakla
                            model.SliderImage.Add("/uploads/" + uniqueFileName);
                        }
                    }
                }

                if (_sliderManager.Add(model) > 0)
                {
                    return RedirectToAction("Index", "Slider");
                }
                else
                {
                    ModelState.AddModelError("DbError", "Veritabanına eklenemedi");
                    return View(model);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("GeneralException", ex.Message);
                return View(model);
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

