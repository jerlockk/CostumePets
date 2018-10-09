using System.Collections.Generic;

namespace Mascotas.Models
{
    public class PostProductoMV
    {
        public Post Post { get; set; }
        public List<Productoxpost> Productoxposts { get; set; }
    }
}