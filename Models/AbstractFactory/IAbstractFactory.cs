namespace AbstractFactory.Models.Abstract_Factory
{
    public interface IAbstractFactory
    {

        public IMoneda createMoneda(string colorMoneda, int valorMoneda, bool isStarCoin);

        public IBloqueInterrogante createBloqueInterrogante(string colorBloque, bool hasBricks, bool hasUpgrade);

    }
}
