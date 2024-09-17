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
                        string fileName = formFile.FileName;

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

                        if(_imageManager.Add(imageViewModel) > 0)
                        {
                            // Yüklemeler başarılı oldukça log yazılabilir
                        }
                        else
                        {
                            // Hatalı ise ayrı bir uyarı yapılabilir.
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
                if(!ModelState.IsValid)
                {
                    return View(model);
                }
                model.AppUserId=1 ;
                if (_categoryManager.Update(model)>0)
                    return RedirectToAction("Index", "Account");
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

                return RedirectToAction("Index", "Account");
            }


            return RedirectToAction("Index", "Account");
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction("Index", "Account");
            }
            catch
            {
                return View();
            }
        }
    }
}
