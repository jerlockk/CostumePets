using System.ComponentModel.DataAnnotations;

namespace Mascotas.Models
{
    public class ImagenPost
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "*Este campo es obligatorio")]
        public string ImageUrl { get; set; }
    }
}