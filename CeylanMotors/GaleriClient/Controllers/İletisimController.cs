using Galeri.DAL.DataContext;
using Galeri.Entities.Concrete;
using Galeri.ViewModel.Guest;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CeylanMotors.Controllers
{
    public class İletisimController : Controller
    {
        private readonly GaleriDbContext _context;
        public İletisimController(GaleriDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
		public IActionResult SendMessage()
		{
			GuestViewModel vm = new GuestViewModel();
			return View(vm);
		}
		[HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SendMessage(GuestViewModel model)
        {
            Guest guest = new Guest();
            guest.Id = model.Id;
            guest.Name = model.Name;
            guest.Surname = model.Surname;
            guest.Description = model.Description;           
            guest.Phone = model.Phone;     
            guest.Message = model.Message;            
            if (ModelState.IsValid)
            {
                _context.Guests.Add(guest);
               await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
            
            
        }
    }
}
