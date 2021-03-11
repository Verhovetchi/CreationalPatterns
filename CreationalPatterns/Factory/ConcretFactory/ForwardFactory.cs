using Factory.Factory;
using Factory.Product;
using Factory.ConcretProduct;

namespace Factory.ConcretFactory
{
     class ForwardFactory : IPlayerFactory
     {
          public IPlayer createPlayer() => new Forward();
     }
}
