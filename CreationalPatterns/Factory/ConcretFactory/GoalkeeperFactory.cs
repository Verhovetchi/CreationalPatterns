using Factory.Factory;
using Factory.Product;
using Factory.ConcretProduct;

namespace Factory.ConcretFactory
{
     class GoalkeeperFactory : IPlayerFactory
     {
          public IPlayer createPlayer() => new Goalkeeper();
     }
}
