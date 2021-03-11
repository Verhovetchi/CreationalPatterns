using Factory.Factory;
using Factory.Product;
using Factory.ConcretProduct;

namespace Factory.ConcretFactory
{
     class DefenderFactory : IPlayerFactory
     {
          public IPlayer createPlayer() => new Defender();
     }
}
