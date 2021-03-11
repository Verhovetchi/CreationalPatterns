using System;
using Factory.Product;

namespace Factory.ConcretProduct
{
     class Midfield : IPlayer
     {
          public void Play() => Console.WriteLine("I am a Midfield.\tMy main goal is to notes the assists!");
     }
}
