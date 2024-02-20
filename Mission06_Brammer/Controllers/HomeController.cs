using Microsoft.AspNetCore.Mvc;
using Mission06_Brammer.Models;
using System.Diagnostics;

namespace Mission06_Brammer.Controllers
{
    public class HomeController : Controller
    {
        private Context _context;
        public HomeController(Context temp)
        {
            _context = temp;
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
            ViewBag.Cats = _context.Categories
                .OrderBy(x => x.Category)
                .ToList();

            return View("Movies", new Movies());
        }
        [HttpPost]
        public IActionResult Movies(Movies response)
        {
            if(ModelState.IsValid)
            {
                _context.Movies.Add(response);
                _context.SaveChanges();
                return RedirectToAction("List");
            }
            else
            {
                ViewBag.Cats = _context.Categories
                    .OrderBy(x => x.Category)
                    .ToList();

                return View(response);
            }
            
        }

        public IActionResult List()
        {
            var list = _context.Movies
                .Where(x => x.Title != null)
                .OrderBy(x => x.Title).ToList();

            return View(list);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);


            ViewBag.Cats = _context.Categories
                .OrderBy(x => x.Category)
                .ToList();

            return View("Movies", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Movies updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Movies deleteRow)
        {
            _context.Movies.Remove(deleteRow);
            _context.SaveChanges();

            return RedirectToAction("List");
        }

    }
}
