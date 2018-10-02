using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Mascotas.Areas.Identity.Data;

namespace Mascotas.Models
{
    public class Post
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "*Este campo es obligatorio")]
        [Display(Name = "Título")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "*Este campo es obligatorio")]
        public string Materiales { get; set; }
        [Required(ErrorMessage = "*Este campo es obligatorio")]
        public string Contenido { get; set; }
        [Required(ErrorMessage = "*Este campo es obligatorio")]
        public bool Estado { get; set; }
        [Required(ErrorMessage = "*Este campo es obligatorio")]
        [Display(Name = "Video")]
        public string UrlVideo { get; set; }
        [Required(ErrorMessage = "*Este campo es obligatorio")]
        public UserIdentity Usuario { get; set; }
        [Required(ErrorMessage = "*Este campo es obligatorio")]
        public List<ImagenPost> Imagenes { get; set; }
        [Required(ErrorMessage = "Debe agregar minimo un producto")]
        public List<Productoxpost> Productoxposts { get; set; }
    }
}