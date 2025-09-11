using System;
using System.Linq;

namespace LINQ_Watford_Koby
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an array of Game objects
            Game[] games = new Game[]
            {
                new Game("LiS", 'M', "Choices Matter"),
                new Game("LiS BTS", 'M', "Choices Matter"),
                new Game("The Awesome Adventures of Captain Spirit", 'M', "Choices Matter"),
                new Game("LiS2", 'M', "Choices Matter"),
                new Game("LiS TC", 'M', "Choices Matter"),
                new Game("LiS DE", 'M', "Choices Matter"),
                new Game("Lost Record: Bloom and Rage", 'M', "Choices Matter"),
                new Game("LiS EP 1 Chrysalis", 'M', "Choices Matter"),
                new Game("LiS EP 2 Out of Time", 'M', "Choices Matter"),
                new Game("LiS EP 3 Chaos Theory", 'M', "Choices Matter"),
            };

            // LINQ query: select games with titles shorter than 9 characters
            var shortGames = from game in games
                             where game.Title.Length < 9
                             select $"Game Title: {game.Title.ToUpper()}";

            // Print the short-titled games
            foreach (var game in shortGames)
            {
                Console.WriteLine(game);
            }

            // LINQ method syntax: find the game titled "LiS" and display its details
            var lis = games.Where(game => game.Title == "LiS")
                      .Select(game => $"Title: {game.Title}, ESRB: {game.Esrb}, Genre: {game.Genre}");

            // Print first result (if found)
            Console.WriteLine(lis.FirstOrDefault());

            // LINQ query: select titles of all 'M' rated games
            var mRated = from game in games
                         where game.Esrb == 'M'
                         select game.Title;

            Console.WriteLine("M Rated Games:");
            foreach (var game in mRated)
            {
                Console.WriteLine(game);
            }

            // LINQ query: select titles of all 'E' rated games with "Action" in their genre
            var eRatedAction = from game in games
                               where game.Esrb == 'E' && game.Genre.Contains("Action")
                               select game.Title;

            Console.WriteLine("E Rated Games:");
            foreach (var game in eRatedAction)
            {
                Console.WriteLine(game);
            }
        }
    }
}
