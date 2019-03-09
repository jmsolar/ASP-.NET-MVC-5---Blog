using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Futbolizando_Fútbol_Blog.Models
{
	public class LoginViewModel
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Usuario")]
        public string Username { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Correo electrónico")]
        [EmailAddress(ErrorMessage = "Formato de correo electrónico inválido")]
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
}