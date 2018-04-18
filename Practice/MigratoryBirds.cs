using System;
using System.Linq;

namespace MyHackerrankChallenges.Practice
{
    internal class MigratoryBirds : IChallenge
    {
        public void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = migratoryBirds(n, ar);
            Console.WriteLine(result);
        }

        private int migratoryBirds(int i, int[] ar)
        {
            var g = ar.OrderBy(ave => ave).GroupBy(ave => ave).ToArray();
            var max = g.Max(el => el.Count());
            var val = g.FirstOrDefault(e => e.Count() == max);
            return val?.Key ?? 0;
        }
    }
}