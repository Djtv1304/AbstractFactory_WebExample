using System.ComponentModel.DataAnnotations;

namespace AbstractFactory.Models
{
    public class Usuario
    {

        [Key]
        public int IdUsuario { get; set; }

        [Required]
        public string Mail { get; set; }

        [Required]
        public string Password {  get; set; }

    }
}
