using System;
using System.Linq;

namespace Singleton
{
     class Program
     {
          static void Main(string[] args)
          {
               SoccerContext db = SoccerContext.Instance;
               SoccerContext db1 = SoccerContext.Instance;

               Console.WriteLine($"\ndb.GetHashCode() => {db.GetHashCode()}");
               Console.WriteLine($"db1.GetHashCode() => {db1.GetHashCode()}\n");


               var teams = db.Teams.ToList();
               var players = db.Players.ToList();

               var result = teams.GroupJoin(players, t => t.Id, p => p.TeamId,
                    (team, player) => new
                    {
                         Players = player,
                         Teams = team
                    });

               foreach (var team in result)
               {
                    Console.WriteLine($"Team: {team.Teams.Name}");

                    foreach (var player in team.Players)
                    {
                         Console.WriteLine($"\t" +
                              $"{player.Name}\t{player.Surname}\t{player.Age(player.Born_Date)}\t{player.Position}");
                    }

                    Console.WriteLine();
               }


               Console.ReadKey();
          }
     }
}
