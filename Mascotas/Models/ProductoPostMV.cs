using System.Collections.Generic;

namespace Mascotas.Models
{
    public class ProductoPostMV
    {
        public List<Producto> Productos { get; set; }
        public List<Post> Posts { get; set; }
    }
}