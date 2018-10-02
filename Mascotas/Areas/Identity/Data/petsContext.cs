using Mascotas.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Mascotas.Areas.Identity.Data
{
    public class petsContext : IdentityDbContext<UserIdentity>
    {
        public petsContext(DbContextOptions<petsContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<ImagenPost> ImagenPosts { get; set; }
        public DbSet<ImagenProducto> ImagenProductos { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Productoxpost> Productoxposts { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<Calificacion> Calificaciones { get; set; }
    }
}
