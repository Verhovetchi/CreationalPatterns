using System;
using Singleton.Models;
using System.Threading;
using System.Data.Entity;
using System.Configuration;
using System.Data.SqlClient;

namespace Singleton
{
     public class SoccerContext : DbContext
     {
          private static readonly object padlock = new object();

          public DbSet<Player> Players { get; set; }
          public DbSet<Team> Teams { get; set; }

          private static string connectionString = ConfigurationManager.ConnectionStrings["SoccerContext"].ConnectionString;
          
          SqlConnection connection = new SqlConnection(connectionString);

          private static SoccerContext _soccerContext;

          private SoccerContext() 
          {
               try
               {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Openning Connection ...");
                    connection.Open();
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

          ~SoccerContext()
          {
               connection.Close();
               Console.ForegroundColor = ConsoleColor.Red;
               Console.WriteLine("Connection closed!");
               Thread.Sleep(500);
          }

     }
}
