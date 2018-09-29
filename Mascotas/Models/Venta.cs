using System;
using System.ComponentModel.DataAnnotations;
using Mascotas.Areas.Identity.Data;

namespace Mascotas.Models
{
    public class Venta
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "*Este campo es obligatorio")]
        public DateTime FechaVenta { get; set; }
        [Required(ErrorMessage = "*Este campo es obligatorio")]
        public float TotalVenta { get; set; }
        [Required(ErrorMessage = "*Este campo es obligatorio")]
        public string DireccionVenta { get; set; }
        [Required(ErrorMessage = "*Este campo es obligatorio")]
        public string Telefono { get; set; }
        [Required(ErrorMessage = "*Este campo es obligatorio")]
        public string TipoPago { get; set; }
        [Required(ErrorMessage = "*Este campo es obligatorio")]
        public UserIdentity Usuario { get; set; }

    }
}