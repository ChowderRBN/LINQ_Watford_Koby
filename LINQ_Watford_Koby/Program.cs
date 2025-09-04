using System;
using System.Collections.Generic;
using System.Collections;

namespace LINQ_Watford_Koby;

internal class Program
{
    static void Main(string[] args)
    {
        // Create a Dictionary to store ranked games (Key = rank, Value = game title)
        Dictionary<int, string> topGames = new Dictionary<int, string>();
        topGames.Add(1, "Life is Strange");
        topGames.Add(2, "Life is Strange BTS");
        topGames.Add(3, "Life is Strange 2");
        topGames.Add(4, "Life is Strange TC");
        topGames.Add(5, "Life is Strange DE");
        topGames.Add(6, "The Awesome Adventures of Captain Spirit");
        topGames.Add(7, "Lost Records: Bloom and Rage");
        topGames.Add(8, "Life is Strange BTS Special Episode Farewell");
        topGames.Add(9, "Life is Strange Episode 1 Chrysalis");
        topGames.Add(10, "Life is Strange Episode 2 Out of Time");

        // Loop through the dictionary and print all key/value pairs
        foreach (KeyValuePair<int, string> kvp in topGames)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }

        // Check if the dictionary contains a game with key 1
        if (topGames.ContainsKey(1))
        {
            // Print the game at key 3 (favorite game)
            Console.WriteLine($"My favorite game is: {topGames[3]}");
        }

        string result = "";

        // Try to get a value at key 11 (which does not exist)
        topGames.TryGetValue(11, out result);

        // If a value exists at key 11, print it; otherwise print a fallback message
        if (result != "")
        {
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("There is no game in the eleventh postition. Awe man are you cereal?");
        }

        // Update the value at key 2 (if it exists) with the same string
        if (topGames.ContainsKey(2))
        {
            topGames[2] = "Life is Strange BTS";
        }

        // Print the updated value at key 2
        Console.WriteLine(topGames[2]);

        // Convert Dictionary into a Hashtable
        Hashtable hashTable = new Hashtable(topGames);

        // Retrieve favorite game at key 3 from the Hashtable
        string favGame = (string)hashTable[3];

        Console.WriteLine($"Favorite Game: {favGame}");

        // Create a Hashtable of U.S. state capitals
        Hashtable capitals = new Hashtable()
        {
            { "Oklahoma", "Oklahoma City" },
            { "New York", "Albany" },
            { "Texas", "Austin" },
            { "Ohio", "Columbus" },
        };

        // Loop through and print all capitals
        foreach (DictionaryEntry kvp in capitals)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }

        // Clear the capitals hashtable (removes all entries)
        capitals.Clear();
    }
}
