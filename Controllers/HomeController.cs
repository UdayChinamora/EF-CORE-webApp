using Microsoft.AspNetCore.Mvc;

using MovieList.Models;

using System.Diagnostics;

namespace MovieList.Controllers
{
    public class HomeController : Controller
    {
       public MovieContext context { get; set; }

        public HomeController (MovieContext ctx) => context = ctx;

        public IActionResult Index()
        {
            var movies =context.Movies.OrderBy(m=> m.Name).ToList();
           
            
            return View(movies);
        }

       

    }
}