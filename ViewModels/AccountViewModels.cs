using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Futbolizando_Fútbol_Blog.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [EmailAddress(ErrorMessage = "El formato del campo {0} es inválido")]
        [DataType(DataType.EmailAddress), Display(Name = "Correo electrónico")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Código")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "¿Recordar este explorador?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [EmailAddress(ErrorMessage = "El formato del campo {0} es inválido")]
        [DataType(DataType.EmailAddress), Display(Name = "Correo electrónico")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Usuario")]
        public string Username { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [EmailAddress(ErrorMessage = "El formato del campo {0} es inválido")]
        [DataType(DataType.EmailAddress), Display(Name = "Correo electrónico")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [DataType(DataType.Password)]
        [Display(Name = "Repetir contraseña")]
        [Compare("Password", ErrorMessage = "Las contraseñas ingresadas no coinciden")]
        public string RepeatPassword { get; set; }

        [Display(Name = "¿Recordar cuenta?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel: Entity
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [EmailAddress(ErrorMessage = "El formato del campo {0} es inválido")]
        [DataType(DataType.EmailAddress), Display(Name = "Correo electrónico")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Usuario")]
        public string Username { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(15, ErrorMessage = "La longitud del campo {0} debe ser al menos {2}", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmar contraseña")]
        [Compare("Password", ErrorMessage = "Las contraseñas ingresadas no coinciden")]
        public string ConfirmPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Token proveedor")]
        [MaxLength(25)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string ProviderPass { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [EmailAddress(ErrorMessage = "El formato del campo {0} es inválido")]
        [DataType(DataType.EmailAddress), Display(Name = "Correo electrónico")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(15, ErrorMessage = "La longitud del campo {0} debe ser al menos {2}", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmar contraseña")]
        [Compare("Password", ErrorMessage = "Las contraseñas ingresadas no coinciden")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Usuario")]
        public string Username { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [EmailAddress(ErrorMessage = "El formato del campo {0} es inválido")]
        [DataType(DataType.EmailAddress), Display(Name = "Correo electrónico")]
        public string Email { get; set; }
    }
}
