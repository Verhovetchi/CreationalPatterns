using System;
using Factory.Product;

namespace Factory.ConcretProduct
{
     class Goalkeeper : IPlayer
     {
          public void Play() => Console.WriteLine("I am a Goalkeeper.\tMy main goal is to defend the goal!");
     }
}
