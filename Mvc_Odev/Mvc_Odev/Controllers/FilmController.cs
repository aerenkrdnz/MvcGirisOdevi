using Microsoft.AspNetCore.Mvc;
using Mvc_Odev.Models;

namespace Mvc_Odev.Controllers
{
	public class FilmController : Controller
	{
		public IActionResult Index()
		{
			var movie = new Movies()
			{
				Id = 4,
				Film = "Başlangıç",
				Kategori = "Bilim-Kurgu",
				Yapimci = "Christopher Nolan"
			};

			return View(movie);
        }
		public IActionResult List()
		{

		
        var movie1 = new Movies()
			{
				Id = 1,
				Film = "Karayip Korsanları",
				Kategori = "Macera",
				Yapimci = "Jerry Bruckheimer"
			};
			var movie2 = new Movies()
			{
				Id = 2,
				Film = "Kolpaçino",
				Kategori = "Komedi-Dram",
				Yapimci = "Şenol Zencir"
			};
			var movie3 = new Movies()
			{
				Id = 3,
				Film = "Kutsal Damacana",
				Kategori = "Komedi",
				Yapimci = "Şenol Zencir"
			};

			var movies = new List<Movies>();
			movies.Add(movie1);
			movies.Add(movie2);
			movies.Add(movie3);


			return View(movies);
        }
    }
}
