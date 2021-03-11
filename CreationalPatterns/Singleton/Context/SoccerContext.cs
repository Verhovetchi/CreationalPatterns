using System;
using Singleton.Models;
using System.Data.Entity;
using System.Data.SqlClient;

namespace Singleton
{
     public class SoccerContext : DbContext
     {
          private static readonly object padlock = new object();

          public DbSet<Player> Players { get; set; }
          public DbSet<Team> Teams { get; set; }

          private const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=SoccerContext;Integrated Security=True";
          
          private static SoccerContext _soccerContext;

          private SoccerContext() 
          {
               SqlConnection conn = new SqlConnection(connectionString);

               try
               {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Openning Connection ...");
                    conn.Open();
                    Console.WriteLine("Connection succeeded!");
                    Console.ForegroundColor = ConsoleColor.White;
               }
               catch (Exception e)
               {
                    Console.WriteLine("Error: " + e.Message);
               }
          }


          public static SoccerContext Instance
          {
               get
               {
                    if (_soccerContext == null)
                    {
                         lock (padlock)
                         {
                              if (_soccerContext == null)
                                   _soccerContext = new SoccerContext();
                         }
                    }

                    return _soccerContext;
               }
          }

     }
}
