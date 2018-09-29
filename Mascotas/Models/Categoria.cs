using System.ComponentModel.DataAnnotations;

namespace Mascotas.Models
{
    public class Categoria
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "*Este campo es obligatorio")]
        public string NomCategoria { get; set; }
    }
}