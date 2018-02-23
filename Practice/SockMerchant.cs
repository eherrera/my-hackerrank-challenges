using System;
using System.Collections.Generic;
using System.Linq;

namespace MyHackerrankChallenges.Practice
{
    public class SockMerchant : IChallenge
    {
        public void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = sockMerchant(n, ar);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        static int sockMerchant(int n, int[] ar)
        {
            // Complete this function
            var sockPairs = new Dictionary<int, int>();
            foreach (var color in ar)
            {
                if (sockPairs.ContainsKey(color))
                {
                    sockPairs[color]++;
                }
                else
                {
                    sockPairs.Add(color, 1);
                }
            }
            return sockPairs.Sum(e => e.Value / 2);
        }
    }
}
