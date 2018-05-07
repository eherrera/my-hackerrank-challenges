using System;
using System.Collections.Generic;
using System.Linq;

namespace MyHackerrankChallenges.Practice
{
    public class BonAppetit : IChallenge
    {
        public void Main(string[] args)
        {
            var firstLine = Array.ConvertAll(Console.ReadLine()?.Split(' '), int.Parse);
            var items = Array.ConvertAll(Console.ReadLine()?.Split(' '), int.Parse);
            var thirdLine = Console.ReadLine();
            var result = GetBonAppetit(firstLine, items, int.Parse(thirdLine));
            Console.WriteLine(result);
        }

        private static string GetBonAppetit(IReadOnlyList<int> firstLine, int[] itemsPrices, int bCharged)
        {
            var k = firstLine[1];
            var sharedItemsTotalPrice = itemsPrices.Where((t, i) => i != k).Sum();
            var bActual = sharedItemsTotalPrice / 2;
            return bCharged == bActual ? "Bon Appetit" : (bCharged - bActual).ToString();   
        }
    }
}