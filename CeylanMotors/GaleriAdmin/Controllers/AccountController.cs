using Galeri.BLL.Managers.Concrete;
using Galeri.DAL.DataContext;
using Galeri.Entities.Concrete;
using Galeri.ViewModel.Category;
using Galeri.ViewModel.Guest;
using Galeri.ViewModel.Login;
using Galeri.ViewModel.Slider;
using Galeri.ViewModel.Yakinda;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private readonly GaleriDbContext _context;
        public AccountController(CategoryManager categoryManager, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, SliderManager sliderManager,YakindaManager yakindaManager,GaleriDbContext context)
        {
            _categoryManager = categoryManager;
            _userManager = userManager;
            _signInManager = signInManager;
            _sliderManager = sliderManager;
            _yakindaManager= yakindaManager;
            _context = context;
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

        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
            public async Task<IActionResult> Login(LoginViewModel model)
            {

            if (!ModelState.IsValid)
            {
                return View(model);
            }

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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            
            return RedirectToAction("Index", "Home");
        }
        public IActionResult messages()
        {
            List<Guest> guests = _context.Guests.ToList();
            List<GuestViewModel> models = new List<GuestViewModel>();
            foreach (var item in guests)
            {
                GuestViewModel model = new GuestViewModel();
                model.Id = item.Id;
                model.Name = item.Name;
                model.Surname = item.Surname;
                model.Description = item.Description;
                model.Phone = item.Phone;
                model.Message = item.Message;
                models.Add(model);
            }

            return View(models);
        }

    }
}
