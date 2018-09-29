using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Mascotas.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the userIdentity class
    public class UserIdentity : IdentityUser
    {
        [Required]
        [MaxLength(14)]
        [MinLength(10)]
        public long NumIdentificacion { get; set; }
        [Required]
        [MaxLength(30)]
        [MinLength(4)]
        public string Nombres { get; set; }
        [Required]
        [MaxLength(30)]
        [MinLength(4)]
        public string Apellidos { get; set; }
        [Required]
        public bool EstadoTerminos { get; set; }
    }
}
