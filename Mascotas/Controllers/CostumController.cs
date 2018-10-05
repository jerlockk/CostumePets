using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mascotas.Models;
using Mascotas.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;

namespace Mascotas.Controllers
{
    public class CostumController : Controller
    {
        private readonly petsContext _context;

        public CostumController(petsContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<ProductoPostMV>> Index()
        {
            var productos = _context.Productos.Include(x => x.Imagen)
                .Include(x => x.Categoria).ToListAsync();
            var posts =  _context.Posts.ToListAsync();
            var prodPostMv= new ProductoPostMV
            {
                Productos = await productos,
                Posts = await posts
            };
            return View(prodPostMv);
        }

        public async Task<ActionResult<Producto>> Cats()
        {
            var catProducts = _context.Productos.Include(x => x.Imagen)
                .Where(x => x.TipoMascota == "gato").ToListAsync();
            return View(await catProducts);
        }

        public async Task<ActionResult<Producto>> Dogs()
        {
            var dogProducts = _context.Productos.Include(x => x.Imagen)
                .Where(x => x.TipoMascota == "perro").ToListAsync();
            return View(await dogProducts);
        }

        public async Task<ActionResult<ProductoPostMV>> Posts()
        {
            var posts = (from p in _context.Posts
                select new Post
                {
                    Titulo = p.Titulo,
                    Contenido = p.Contenido,
                    FechaPublicacion = p.FechaPublicacion,
                    Imagenes = p.Imagenes,
                    Comentarios = p.Comentarios,
                    Calificaciones = p.Calificaciones
                }).ToListAsync();
                var productos = _context.Productos.
                Include(x => x.Imagen).ToListAsync();
                var result = new ProductoPostMV
                {
                    Posts = await posts,
                    Productos = await productos
                };
            ViewData["Aside"] = result;
            return View(result);
        }

        public async Task<ActionResult<Post>> Post(long id)
        {
            var post = _context.Posts.FindAsync(id);
            var posts = (from p in _context.Posts
                select new Post
                {
                    Titulo = p.Titulo,
                    Contenido = p.Contenido,
                    FechaPublicacion = p.FechaPublicacion,
                    Imagenes = p.Imagenes,
                    Comentarios = p.Comentarios,
                    Calificaciones = p.Calificaciones
                }).ToListAsync();
            var productos = _context.Productos.
                Include(x => x.Imagen).ToListAsync();
            var result = new ProductoPostMV
            {
                Posts = await posts,
                Productos = await productos
            };
            ViewData["Aside"] = result;
            return View(await post);
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