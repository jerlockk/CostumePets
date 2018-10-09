using System.ComponentModel.DataAnnotations;
using Mascotas.Areas.Identity.Data;

namespace Mascotas.Models
{
    public class Calificacion
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "*Este campo es obligatorio")]
        [Display(Name = "Calificación")]
        public int Valor { get; set; }
        [Required(ErrorMessage = "*Este campo es obligatorio")]
        public string UsuarioId { get; set; }
        public UserIdentity Usuario { get; set; }
        [Required(ErrorMessage = "*Este campo es obligatorio")]
        public long PostId { get; set; }
        public Post Post { get; set; }
    }
}