using System;
using Factory.Factory;
using Factory.ConcretFactory;

namespace Factory
{
     enum Position
     {
          Goalkeeper,
          Defender,
          Midfield,
          Forward
     }

     class Program
     {
          static void Main(string[] args)
          {
               IPlayerFactory playerFactory = CreatePlayersByPosition(Position.Goalkeeper);
               var goalkeeper = playerFactory.createPlayer();

               playerFactory = CreatePlayersByPosition(Position.Defender);
               var defender = playerFactory.createPlayer();


               playerFactory = CreatePlayersByPosition(Position.Midfield);
               var midfield = playerFactory.createPlayer();
               
               playerFactory = CreatePlayersByPosition(Position.Forward);
               var forward = playerFactory.createPlayer();
               

               goalkeeper.Play();

               defender.Play();
               
               midfield.Play();
               
               forward.Play();


               Console.ReadKey();
          }

          static IPlayerFactory CreatePlayersByPosition(Position position)
          {
               switch (position)
               {
                    case Position.Goalkeeper:
                         return new GoalkeeperFactory();

                    case Position.Defender:
                         return new DefenderFactory();

                    case Position.Midfield:
                         return new MidfieldFactory();

                    case Position.Forward:
                         return new ForwardFactory();

                    default:
                         return null;
               }
          }
     }
}

          