using System;
using Factory.Product;

namespace Factory.ConcretProduct
{
     class Forward : IPlayer
     {
          public void Play() => Console.WriteLine("I am a Forward.\t\tMy main goal is to score the goals!");
     }
}
