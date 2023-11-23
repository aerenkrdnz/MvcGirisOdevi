using Microsoft.AspNetCore.Mvc;
using Mvc_Odev.Models;

namespace Mvc_Odev.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Film = "Karetekid";
            ViewBag.Kategori = "Aksiyon";
            ViewBag.Yapimci = "Jerry Weintraub";


			return View();
        }
    }
}
