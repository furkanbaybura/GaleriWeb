using Galeri.BLL.Managers.Concrete;
using Galeri.DTO;
using Galeri.ViewModel.Category;
using Galeri.ViewModel.Picture;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace GaleriAdmin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        private CategoryManager _categoryManager;
        private ImageManager _imageManager;

        public CategoryController(CategoryManager categoryManager, ImageManager imageManager)
        {
            _categoryManager = categoryManager;
            _imageManager = imageManager;
        }

        // GET: CategoryController
        public ActionResult Index()
        {

            IEnumerable<CategoryViewModel> list = _categoryManager.GetAll().ToList();

            IEnumerable<ImageViewModel> imageList = _imageManager.GetAll().ToList();

            ViewBag.ImageList = imageList;

            return View(list);
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            CategoryViewModel? model = _categoryManager.Get(id);
            IEnumerable<ImageViewModel> imageList = _imageManager.GetAll().ToList();
            ViewBag.ImageList = imageList;
            return View(model);
        }

        // GET: CategoryController/Create
        [HttpGet]
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
            
            int appUserId = Convert.ToInt32(HttpContext.User.Claims.Where(c => c.Type == ClaimTypes.NameIdentifier).FirstOrDefault().Value);

            try
            {
                ModelState.Remove("PictureName");
                ModelState.Remove("PictureFile");

                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                model.AppUserId = appUserId;

                int insertId = _categoryManager.Add(model,true);
                if (insertId > 0)
                {
                    IFormFile[] formFiles = model.FormFile;

                    foreach(IFormFile formFile in formFiles)
                    {
                        ImageViewModel imageViewModel = new ImageViewModel();  
                        string fileName = insertId + "_" + DateTime.Now.ToString("ddMMyyyyHHmmss") + "_" + formFile.FileName; // 1066_image_3.jpeg, 1070_image_3.jpeg

                        var dosyadakiFileName = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);

                        var konum = dosyadakiFileName;

                        //Kaydetmek için bir akış ortamı oluşturalım
                        var akisOrtami = new FileStream(konum, FileMode.Create);
                        var memory = new MemoryStream();

                        //Resmi kaydet
                        formFile.CopyTo(akisOrtami);
                        formFile.CopyTo(memory);

                        imageViewModel.ImageName = fileName;
                        imageViewModel.ImageFile = memory.ToArray();
                        imageViewModel.AppUserId = appUserId;
                        imageViewModel.CategoryId = insertId;

                        akisOrtami.Dispose();
                        memory.Dispose();

                        if (_imageManager.Add(imageViewModel) > 0)
                        {
                            TempData["SuccessMessage"] = "Yükleme başarılı oldu!";
                        }
                        else
                        {
                            TempData["ErrorMessage"] = "Yükleme sırasında bir hata oluştu!";
                        }
                                               
                    }

                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ModelState.AddModelError("DbError", "Veritabanı ekleme hatası");

                    return View(model);
                }

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("GeneralException", ex.Message);
                ModelState.AddModelError("GeneralInnerException", ex.InnerException?.Message);
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
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                model.AppUserId = 1;  // AppUserId'yi doğru bir şekilde set ediyorsunuz, örnekte 1.

                // Kategori güncellemesi
                if (_categoryManager.Update(model) > 0)
                {

                    // Yeni resimler eklendiyse işlemi yap
                    if (model.FormFile != null && model.FormFile.Length > 0)
                    {
                        List<ImageViewModel> imageVmlist = _imageManager.GetImagesByCategoryId(id).ToList();

                        foreach (ImageViewModel imageVm in imageVmlist)
                        {
                            string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", imageVm.ImageName);

                            if (_imageManager.Delete(imageVm) > 0)
                            {
                                try
                                {
                                    System.IO.File.Delete(imagePath);
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }

                            }
                        }


                        foreach (IFormFile formFile in model.FormFile)
                        {
                            ImageViewModel imageViewModel = new ImageViewModel();
                            string fileName = formFile.FileName;

                            var dosyadakiFileName = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);
                            var konum = dosyadakiFileName;

                            // Dosyayı kaydet
                            using (var akisOrtami = new FileStream(konum, FileMode.Create))
                            {
                                formFile.CopyTo(akisOrtami);
                            }

                            // Hafızaya yükleyip image modelini doldur
                            using (var memory = new MemoryStream())
                            {
                                formFile.CopyTo(memory);
                                imageViewModel.ImageName = fileName;
                                imageViewModel.ImageFile = memory.ToArray();
                                imageViewModel.AppUserId = model.AppUserId;
                                imageViewModel.CategoryId = id;

                                _imageManager.Add(imageViewModel);
                            }
                        }
                    }


                    return RedirectToAction("Index", "Account");
                }
                else
                {
                    ModelState.AddModelError("DbError", "Veritabanına güncelleme yapılamadı");
                    return View(model);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("GeneralException", ex.Message);
                return View();
            }
        }
        
        //[HttpGet]
        //public IActionResult Delete(int id)
        //{
        //    CategoryViewModel model = _categoryManager.Get(id);

        //    return View(model);
        //}

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            try
            {
                // Kategoriyi getirin
                CategoryViewModel category = _categoryManager.Get(id);
                if (category == null)
                {
                    return NotFound();
                }

                // Kategoriye bağlı tüm fotoğrafları getirin
                List<ImageViewModel> imageList = _imageManager.GetImagesByCategoryId(id).ToList();

                // Her bir fotoğrafı sil
                foreach (var image in imageList)
                {
                    // Fotoğrafın dosya sistemindeki yolunu oluştur
                    string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", image.ImageName);

                    // Dosya sisteminden fotoğrafı sil
                    if (System.IO.File.Exists(imagePath))
                    {
                        System.IO.File.Delete(imagePath);
                    }

                    // Fotoğrafı veritabanından sil
                    _imageManager.Delete(image);
                }

                // Kategoriyi sil
                _categoryManager.Delete(id);

                return Ok();
            }
            catch (Exception ex)
            {
                // Hata durumunda 500 statü kodu döndürün
                return StatusCode(500, new { message = ex.Message });
            }
        }


        public ActionResult DeleteImage(int id)
        {
            ImageViewModel imageViewModel = _imageManager.Get(id);

            int categoryId = imageViewModel.CategoryId;

            string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", imageViewModel.ImageName);

            bool deleteStatus = false;

            if(_imageManager.Delete(imageViewModel) > 0)
            {
                try
                {
                    System.IO.File.Delete(imagePath);
                    deleteStatus = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    
                }
                
            }

            ViewBag.DeleteMessage = deleteStatus ? "Resim başarıyla silindi." : "Resim silme başarısız oldu";

            CategoryViewModel? model = _categoryManager.Get(categoryId);
            IEnumerable<ImageViewModel> imageList = _imageManager.GetAll().ToList();
            ViewBag.ImageList = imageList;

            return RedirectToAction("Details", "Category", model);
        }
    }
}
