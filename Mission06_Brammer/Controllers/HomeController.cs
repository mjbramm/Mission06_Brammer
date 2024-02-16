using Microsoft.AspNetCore.Mvc;
using Mission06_Brammer.Models;
using System.Diagnostics;

namespace Mission06_Brammer.Controllers
{
    public class HomeController : Controller
    {
        private Context _context;
        public HomeController(Context someName)
        {
            _context = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Joel()
        {
            return View();
        }

        public IActionResult AddMovie()
        {
            return View("AddMovie");
        }

        [HttpGet]
        public IActionResult Movies()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Movies(Movies response)
        {
            _context.Movies.Add(response);
            _context.SaveChanges();
            return View();
        }
    }
}
