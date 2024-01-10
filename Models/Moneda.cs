namespace AbstractFactory.Models
{
    public interface Moneda
    {

        public string Color {  get; set; }

        public int Valor { get; set; }

        public bool isStarCoin { get; set; }

    }
}
