using Galeri.BLL.Managers.Concrete;
using Galeri.DAL.DataContext;
using Galeri.Entities.Concrete;
using Galeri.ViewModel.Guest;
using Galeri.ViewModel.Slider;
using GaleriAdmin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace GaleriAdmin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly GaleriDbContext _context;
       

        public HomeController(ILogger<HomeController> logger,SliderManager sliderManager, GaleriDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
        
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
      
    }
}
