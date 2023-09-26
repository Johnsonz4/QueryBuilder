using System;
using System.Collections.Generic;
using QueryBuilder.Models;


namespace QueryBuilderStarter
{
    class Program
    {
        static void Main(string[] args)
        {
            var queryBuilder = new QueryBuilder(@"/Users/zoe/Projects/sslab3/sslab3/Data/data.db");
            var pokemonCollection = new List<Pokemon>
            {
                new Pokemon { Name = "Pikachu", Type = "Fire" },
                new Pokemon { Name = "Charizard", Type = "Fire" },
                
            };
            Console.WriteLine("Step 2: Writing Pokemon collection to the database...");
            foreach (var pokemon in pokemonCollection)
            {
                queryBuilder.Create(pokemon);
            }
            Console.WriteLine("collection written to the database.");

            //  Write a single Pokemon object
            var singlePokemon = new Pokemon { Name = "Bulbasaur", Type = "Grass" };
            Console.WriteLine("\nStep 3: Writing a single Pokemon object to the database...");
            queryBuilder.Create(singlePokemon);
            Console.WriteLine("Single Pokemon object written to the database.");

            // BannedGame objects
            var bannedGames = new List<BannedGame>
            {
                new BannedGame { Title = "Game1", Reason = "Violence" },
                new BannedGame { Title = "Game2", Reason = "Violence" },

            };
            Console.ReadLine();
            Console.WriteLine("\nStep 4: Writing BannedGame collection to the database...");
            foreach (var game in bannedGames)
            {
                queryBuilder.Create(game);
            }
            Console.WriteLine("BannedGame collection written to the database.");


            var singleBannedGame = new BannedGame { Title = "Game3", Reason = "Cheating" };
            Console.WriteLine($"\n Step 5: Writing a single BannedGame object to the database...");
            queryBuilder.Create(singleBannedGame);
            Console.WriteLine("Single BannedGame object written to the database.");


            Console.WriteLine("\nStep 1: Erasing all Pokemon records...");
            queryBuilder.DeleteAll<Pokemon>();
            Console.WriteLine("All Pokemon records erased.");
            Console.ReadLine();

        }
    }
}