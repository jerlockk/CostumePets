using System.ComponentModel.DataAnnotations;

namespace Mascotas.Models
{
    public class Imagen
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "*Este campo es obligatorio")]
        public byte[] ImagenBytes { get; set; }
    }
}