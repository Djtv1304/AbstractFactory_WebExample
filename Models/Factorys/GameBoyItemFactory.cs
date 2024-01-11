

using AbstractFactory.Models.Abstract_Factory;

namespace AbstractFactory.Models.Factorys
{
    public class GameBoyItemFactory : IAbstractFactory
    {

        public IMoneda createMoneda(string colorMoneda, int valorMoneda, bool isStarCoin)
        {

            return new MonedaGameboy
            {

                Color = colorMoneda,
                Valor = valorMoneda,
                isStarCoin = isStarCoin
            
            };

        }

        public IBloqueInterrogante createBloqueInterrogante(string colorBloque, bool hasBricks, bool hasUpgrade) 
        {

            return new BloqueInterroganteGameboy
            {

                Color = colorBloque,
                hasBricks = hasBricks,
                hasUpgrade = hasUpgrade

            };
        
        }

    }
}
