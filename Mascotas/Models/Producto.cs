using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Mascotas.Models
{
    public class Producto
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "*Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage = "Este campo solo puede tener un máximo de 30 caracteres")]
        [MinLength(4, ErrorMessage = "Este campo debe tener un mínimo de 4 caracteres")]
        [Display(Name = "Nombre del producto")]
        public string NombreProducto { get; set; }
        [Required(ErrorMessage = "*Este campo es obligatorio")]
        [MaxLength(400, ErrorMessage = "Este campo solo puede tener un máximo de 400 caracteres")]
        [MinLength(10, ErrorMessage = "Este campo debe tener un mínimo de 10 caracteres")]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "*Este campo es obligatorio")]
        [DataType(DataType.Currency)]
        public float Precio { get; set; }
        [Required(ErrorMessage = "*Este campo es obligatorio")]
        [MaxLength(20, ErrorMessage = "Este campo solo puede tener un máximo de 20 caracteres")]
        [MinLength(2, ErrorMessage = "Este campo debe tener un mínimo de 2 caracteres")]
        public string TipoMascota { get; set; }
        [Required(ErrorMessage = "*Este campo es obligatorio")]
        public bool Estado { get; set; }
        [Required(ErrorMessage = "*Este campo es obligatorio")]
        public ImagenProducto Imagen { get; set; }
        [Required(ErrorMessage = "*Este campo es obligatorio")]
        public Categoria Categoria { get; set; }
    }
}