using System.ComponentModel.DataAnnotations;

namespace AbstractFactory.Models
{
    public class MonedaNintendoDS : IMoneda
    {
        [Key]
        public int IdMoneda { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public int Valor { get; set; }

        [Required]
        public bool isStarCoin { get; set; }

        public string Saludar()
        {

            return "Hola, soy una Moneda de NintendoDS de Mario Bros";

        }
    }
}
