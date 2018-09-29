using System.ComponentModel.DataAnnotations;

namespace Mascotas.Models
{
    public class Productoxpost
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "*Este campo es obligatorio")]
        public Post Post { get; set; }
        [Required(ErrorMessage = "*Este campo es obligatorio")]
        public Producto Producto { get; set; }
    }
}