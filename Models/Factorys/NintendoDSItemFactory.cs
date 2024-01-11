using AbstractFactory.Models.Abstract_Factory;

namespace AbstractFactory.Models.Factorys
{
    public class NintendoDSItemFactory : IAbstractFactory
    {
        public IMoneda createMoneda(string color, int valor, bool isStarCoin)
        {

            return new MonedaNintendoDS
            {

                Color = color,
                Valor = valor,
                isStarCoin = isStarCoin

            };

        }

        public IBloqueInterrogante createBloqueInterrogante(string color, bool hasBricks, bool hasUpgrade) 
        {

            return new BloqueInterroganteNintendoDS
            {

                Color = color,
                hasBricks = hasBricks,
                hasUpgrade = hasUpgrade

            };
        
        }
    }
}
