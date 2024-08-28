using Galeri.ViewModel.Message;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CeylanMotors.Controllers
{
    public class İletisimController : Controller
    {
      
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SendMessage(MessageViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Mesajı veritabanına kaydet
                //_context.Messages.Add(new Message
                //{
                //    Content = model.Content,
                //    CreatedAt = DateTime.Now
                //});
                //await _context.SaveChangesAsync();

                
                return RedirectToAction("Iletisim", "Home");
            }

            return View(model);
        }
    }
}
