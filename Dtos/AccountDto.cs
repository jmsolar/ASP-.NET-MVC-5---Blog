using Futbolizando_Fútbol_Blog.Models;
using System.ComponentModel.DataAnnotations;

namespace Futbolizando_Fútbol_Blog.Dtos
{
    public class AccountDto: Entity
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string RepeatPassword { get; set; }

        public bool RememberMe { get; set; }
    }
}