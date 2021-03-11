using System;
using Factory.Product;

namespace Factory.ConcretProduct
{
     class Defender : IPlayer
     {
          public void Play() => Console.WriteLine("I am a Defender.\tMy main goal is to stop the opponents!");
     }
}
