using System;
using System.Collections.Generic;
using System.Linq;

namespace MyHackerrankChallenges.Practice
{
    public class MiniMaxSum : IChallenge
    {
        public void Main(string[] args)
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            long[] arr = Array.ConvertAll(arr_temp, long.Parse);
            Console.WriteLine(string.Join(" ", MiniMax(arr)));
            Console.ReadKey();
        }

        private static IEnumerable<long> MiniMax(long[] arr)
        {
            var result = new[] { long.MaxValue, long.MinValue };
            for (var i = 0; i < arr.Length; i++)
            {
                var sum = arr.Where((t, j) => i != j).Sum();
                if (sum > result[1])
                {
                    result[1] = sum;
                }
                if (sum < result[0])
                {
                    result[0] = sum;
                }
            }

            return result;
        }
    }
}
