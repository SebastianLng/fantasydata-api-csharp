using System;
using System.Linq;
using FantasyData.Api.Client;

namespace FantasyData.Api.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // Connect to client and get data
            var client = new NFLv3StatsClient("api_key_goes_here");
            var players = client.GetPlayers();

            // Write data to console
            foreach(var player in players)
            {
                Console.WriteLine($"{player.PlayerID} - {player.Name} - {player.Team}");
            }

            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();

        }
    }
}

