using Factory.Factory;
using Factory.Product;
using Factory.ConcretProduct;

namespace Factory.ConcretFactory
{
     class MidfieldFactory : IPlayerFactory
     {
          public IPlayer createPlayer() => new Midfield();
     }
}
