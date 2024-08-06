using Galeri.BLL.Managers.Concrete;
using Galeri.Entities.Concrete;
using Galeri.ViewModel.Category;
using Galeri.ViewModel.Login;
using Galeri.ViewModel.Slider;
using Galeri.ViewModel.Yakinda;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace GaleriAdmin.Controllers
{
    
    public class AccountController : Controller
    {
        private CategoryManager _categoryManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly SliderManager _sliderManager;
        private readonly YakindaManager _yakindaManager;
        public AccountController(CategoryManager categoryManager, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, SliderManager sliderManager,YakindaManager yakindaManager)
        {
            _categoryManager = categoryManager;
            _userManager = userManager;
            _signInManager = signInManager;
            _sliderManager = sliderManager;
            _yakindaManager= yakindaManager;
        }
        
        public IActionResult Index()
        {
            IEnumerable<CategoryViewModel> list = _categoryManager.GetAll();
            IEnumerable<SliderViewModel> slider = _sliderManager.GetAll();
            IEnumerable<YakindaViewModel> yakinda = _yakindaManager.GetAll();
            ViewBag.List=slider;
            ViewBag.Yakinda=yakinda;
            return View(list);
           
        }
        public IActionResult Messages()
        {

            return View();
        }

        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
            public async Task<IActionResult> Login(LoginViewModel model)
            {

                AppUser user = await _userManager.FindByEmailAsync(model.Email);
                if (user == null)
                {

                    ModelState.AddModelError(string.Empty, "Kullanıcı adı veya şifre yanlış");
                    return View(model);
                }


                var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, true);
                if (result.Succeeded)
                {

                    return RedirectToAction("Index", "Account");
                }


                ModelState.AddModelError(string.Empty, "Kullanıcı adı veya şifre yanlış");
                return View(model);
            }
    
    }
}
