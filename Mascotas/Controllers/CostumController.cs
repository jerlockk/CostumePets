using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Mascotas.Models;
using Mascotas.Areas.Identity.Data;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Mascotas.Controllers
{
    public class CostumController : Controller
    {
        private readonly petsContext _context;
        private readonly UserManager<UserIdentity> _userManager;
        public CostumController(petsContext context,
                                 UserManager<UserIdentity> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<ActionResult<ProductoPostMV>> Index()
        {
            var productos = _context.Productos.Include(x => x.Imagen)
                .Include(x => x.Categoria).ToListAsync();
            var posts =  _context.Posts.Include(x => x.Imagenes).ToListAsync();
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
            var posts = _context.Posts.Include(x => x.Calificaciones).
                Include(y => y.Imagenes).Include(z => z.Comentarios).ToListAsync();
            var productos = _context.Productos.
                Include(x => x.Imagen).ToListAsync();
            var share = new ProductoPostMV
            {
                Posts = await posts,
                Productos = await productos
            };
            ViewData["Aside"] = share;
            return View(await catProducts);
        }

        public async Task<ActionResult<Producto>> Dogs()
        {
            var dogProducts = _context.Productos.Include(x => x.Imagen)
                .Where(x => x.TipoMascota == "perro").ToListAsync();
            var posts = _context.Posts.Include(x => x.Calificaciones).
                Include(y => y.Imagenes).Include(z => z.Comentarios).ToListAsync();
            var productos = _context.Productos.
                Include(x => x.Imagen).ToListAsync();
            var share = new ProductoPostMV
            {
                Posts = await posts,
                Productos = await productos
            };
            ViewData["Aside"] = share;
            return View(await dogProducts);
        }

        public async Task<ActionResult<ProductoPostMV>> Posts()
        {
            var posts = _context.Posts.Include(x => x.Calificaciones).
            Include(y => y.Imagenes).Include(z => z.Comentarios).ToListAsync();
            var productos = _context.Productos.Include(x => x.Imagen)
            .ToListAsync();
            var result = new ProductoPostMV
            {
                Posts = await posts,
                Productos = await productos
            };
            ViewData["Aside"] = result;
            return View(result);
        }

        public async Task<ActionResult<PostProductoMV>> Post(long id)
        {
            var post = _context.Posts.FindAsync(id);
            var productosxpost = _context.Productoxposts.Where(x => x.Post.Id.Equals(id)).ToListAsync();
            var posts = _context.Posts.Include(x => x.Calificaciones).
                Include(y => y.Imagenes).Include(z => z.Comentarios).ToListAsync();
            var productos = _context.Productos.
                Include(x => x.Imagen).ToListAsync();
            var share = new ProductoPostMV
            {
                Posts = await posts,
                Productos = await productos
            };
            var result = new PostProductoMV
            {
                Post = await post,
                Productoxposts = await productosxpost
            };
            ViewData["Aside"] = share;
            return View(result);
        }

        [HttpPost]
        public JsonResult SaveComment(Comentario c)
        {
            _context.Comentarios.Add(c);
            _context.SaveChanges();
            return Json("Comentario guardado con exito");
        }

        [HttpPost]
        public JsonResult SaveRate(Calificacion c)
        {
            _context.Calificaciones.Add(c);
            _context.SaveChanges();
            return Json("Su calificación ha sido guardada con exito");
        }

        public JsonResult RemoveComment(long id)
        {
            var c = _context.Comentarios.Find(id);
            _context.Comentarios.Remove(c);
            _context.SaveChanges();
            return Json("Comentario eliminado con exito");
        }

        public async Task<IActionResult> About()
        {
            var posts = _context.Posts.Include(x => x.Calificaciones).
                Include(y => y.Imagenes).Include(z => z.Comentarios).ToListAsync();
            var productos = _context.Productos.
                Include(x => x.Imagen).ToListAsync();
            var share = new ProductoPostMV
            {
                Posts = await posts,
                Productos = await productos
            };
            ViewData["Aside"] = share;
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