namespace AbstractFactory.Models
{
    public interface IMoneda
    {

        public string Color { get; set; }

        public int Valor { get; set; }

        public bool isStarCoin { get; set; }

        public string Saludar();

    }
}
