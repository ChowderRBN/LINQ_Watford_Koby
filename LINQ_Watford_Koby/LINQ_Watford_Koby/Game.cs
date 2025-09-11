using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_Watford_Koby
{
    // Defines a Game class with basic properties
    internal class Game
    {
        // Title of the game
        public string Title { get; }

        // ESRB rating (E, T, M, etc.)
        public char Esrb { get; }

        // Genre of the game (e.g., RPG, Action, Adventure)
        public string Genre { get; }

        // Constructor to initialize the game with a title, ESRB rating, and genre
        public Game(string titleParam, char esrbParam, string genreParam)
        {
            Title = titleParam;
            Esrb = esrbParam;
            Genre = genreParam;
        }
    }
}
