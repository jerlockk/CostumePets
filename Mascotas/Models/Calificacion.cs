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
        public Post Post { get; set; }
        [Required(ErrorMessage = "*Este campo es obligatorio")]
        public UserIdentity Usuario { get; set; }
    }
}