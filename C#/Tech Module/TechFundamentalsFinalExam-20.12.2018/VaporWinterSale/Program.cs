using System;
using System.Collections.Generic;
using System.Linq;

namespace VaporWinterSale
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, double> games = new Dictionary<string, double>();
            Dictionary<string, string> contentToGame = new Dictionary<string, string>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Contains('-'))
                {
                    string[] splitToString = input[i].Split('-');
                    string game = splitToString[0];
                    double price = double.Parse(splitToString[1]);
                    
                        games[game] = price;
                    
                }
                else if (input[i].Contains(':'))
                {
                    string[] splitToString = input[i].Split(':');
                    string game = splitToString[0];
                    string dlc = splitToString[1];

                    if (games.ContainsKey(game))
                    {
                        contentToGame[game] = dlc;
                        games[game] *= 1.2;
                    }
                }
            }

            Dictionary<string, double> gamesReducedPrise = new Dictionary<string, double>();
            foreach (var game in games)
            {
                if (contentToGame.ContainsKey(game.Key))
                {
                    gamesReducedPrise[game.Key] = game.Value * 0.5;
                }
                else
                {
                    gamesReducedPrise[game.Key] = game.Value * 0.8;
                }
            }

            foreach (var game in gamesReducedPrise.OrderBy(x => x.Value))
            {
                if (contentToGame.ContainsKey(game.Key))
                {
                    Console.WriteLine($"{game.Key} - {contentToGame[game.Key]} - {game.Value:F2}");
                }

            }

            foreach (var game in gamesReducedPrise.OrderByDescending(x => x.Value))
            {
                if (!contentToGame.ContainsKey(game.Key))
                {
                    Console.WriteLine($"{game.Key} - {game.Value:F2}");
                }
            }
        }
    }
}
