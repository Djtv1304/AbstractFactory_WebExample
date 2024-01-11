namespace AbstractFactory.Models
{
    public interface IBloqueInterrogante
    {

        public string Color { get; set; }

        public bool hasBricks { get; set; }

        public bool hasUpgrade { get; set; }

        public string useBlock();

    }
}
