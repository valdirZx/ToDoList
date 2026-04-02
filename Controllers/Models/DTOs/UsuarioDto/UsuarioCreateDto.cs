using System.ComponentModel.DataAnnotations;

namespace ToDoList.Controllers.Models.DTOs.UsuarioDto
{
    public class UsuarioCreateDto
    {
        [Required, MinLength(3), MaxLength(50)]
        public string Nome { get; set; } = string.Empty;

        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required, MinLength(6), MaxLength(16)]
        public string Senha { get; set; } = string.Empty;
    }
}
