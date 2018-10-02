using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Mascotas.Models;
using Mascotas.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;

namespace Mascotas.Controllers
{
    public class HomeController : Controller
    {
        private readonly petsContext _context;

        public HomeController(petsContext context)
        {
            _context = context;
        }

        public  ActionResult<ProductoPostMV> Index()
        {
            var productos = _context.Productos.Include(x => x.Imagen).Include(x => x.Categorias).ToList();
            var posts =  _context.Posts.ToList();
            var prodPostMv= new ProductoPostMV
            {
                Productos = productos,
                Posts = posts
            };
            return View(prodPostMv);
        }

        public ActionResult Cats()
        {
            return View();
        }

        public ActionResult Dogs()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}