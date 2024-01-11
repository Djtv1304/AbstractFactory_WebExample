using System.ComponentModel.DataAnnotations;

namespace AbstractFactory.Models
{
    public class BloqueInterroganteNintendoDS : IBloqueInterrogante
    {
        [Key]
        public int IdBloque { get; set; }

        [Required]
        public string Color {  get; set; }

        [Required]
        public bool hasBricks { get; set; }

        [Required]
        public bool hasUpgrade { get; set; }

        public string useBlock()
        {

            return "Perfecto, has usado un bloque en tu NintendoDS, obtendrás tu mejora";

        }
    }
}
