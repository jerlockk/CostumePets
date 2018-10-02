using System.ComponentModel.DataAnnotations;

namespace Mascotas.Models
{
    public class ImagenProducto
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "*Este campo es obligatorio")]
        public string ImageUrl { get; set; }
    }
}