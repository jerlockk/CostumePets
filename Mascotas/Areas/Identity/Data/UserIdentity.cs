using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Mascotas.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the userIdentity class
    public class UserIdentity : IdentityUser
    {
        [Required(ErrorMessage = "*Este campo es obligatorio")]
        [MaxLength(14, ErrorMessage = "Este campo solo puede tener un máximo de 14 caracteres")]
        [MinLength(10, ErrorMessage = "Este campo debe tener un mínimo de 10 caracteres")]
        public long NumIdentificacion { get; set; }
        [Required(ErrorMessage = "*Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage = "Este campo solo puede tener un máximo de 30 caracteres")]
        [MinLength(4, ErrorMessage = "Este campo debe tener un mínimo de 4 caracteres")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "*Este campo es obligatorio")]
        [MaxLength(30, ErrorMessage = "Este campo solo puede tener un máximo de 30 caracteres")]
        [MinLength(4, ErrorMessage = "Este campo debe tener un mínimo de 4 caracteres")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "*Este campo es obligatorio")]
        public bool EstadoTerminos { get; set; }
    }
}
