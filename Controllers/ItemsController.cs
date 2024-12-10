using Microsoft.AspNetCore.Mvc;
using MyAspNetCoreApp.Models;

namespace MyAspNetCoreApp.Controllers
{
    public class ItemsController : Controller
    {
        // GET: HomeController
        public IActionResult Overview()
        {
            var item = new Item { Name = "Keyboard", Price = 9.99m };
            return View(item);
        }

    }
}
