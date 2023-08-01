using BtkAkademi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BtkAkademi.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var model = Repository.Applications;
            return View(model);
        }

        public IActionResult Apply()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Apply([FromForm] aday model)
        {
            if (Repository.Applications.Any(c=>c.Email.Equals(model.Email)))
            {
                ModelState.AddModelError("","There is already application");
            }

            if (ModelState.IsValid)
            {
                Repository repository = new Repository(); // Repository sınıfından bir örnek oluşturuluyor.
                repository.Add(model); // Oluşturulan örnek üzerinden Add metodu çağrılıyor.
                return View("Feedback", model);
            }
            return View();

        }

    }

}