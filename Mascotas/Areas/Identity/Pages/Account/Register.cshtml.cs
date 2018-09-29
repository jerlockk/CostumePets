using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Mascotas.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Mascotas.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<UserIdentity> _signInManager;
        private readonly UserManager<UserIdentity> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;

        public RegisterModel(
            UserManager<UserIdentity> userManager,
            SignInManager<UserIdentity> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "*Este campo es obligatorio")]
            [EmailAddress]
            [Display(Name = "Correo electrónico")]
            public string Email { get; set; }

            [Required(ErrorMessage = "*Este campo es obligatorio")]
            [StringLength(100, ErrorMessage = "La contraseña debe tener un mínimo de 6 caracteres y un máximo de 100", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Contraseña")]
            public string Password { get; set; }

            [Required(ErrorMessage = "*Este campo es obligatorio")]
            [DataType(DataType.Password)]
            [Display(Name = "Confirme su contraseña")]
            [Compare("Password", ErrorMessage = "Las contraseñas no coinciden")]
            public string ConfirmPassword { get; set; }
            [Required(ErrorMessage = "*Este campo es obligatorio")]
            [MaxLength(14, ErrorMessage = "Este campo solo puede tener un máximo de 14 caracteres")]
            [MinLength(10, ErrorMessage = "Este campo debe tener un mínimo de 10 caracteres")]
            [Display(Name = "Número de identificación")]
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
            [Display(Name = "¿Acepta los términos y condiciones?")]
            public bool EstadoTerminos { get; set; }
        }

        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            if (ModelState.IsValid)
            {
                var user = new UserIdentity { UserName = Input.Email, Email = Input.Email };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { userId = user.Id, code = code },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return LocalRedirect(returnUrl);
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
