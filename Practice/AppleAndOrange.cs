using System;
using System.Collections.Generic;
using System.Linq;

namespace MyHackerrankChallenges.Practice
{
    public class AppleAndOrange : IChallenge
    {
        /*
         * Complete the countApplesAndOranges function below.
         */
        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            var applesCount = FruitsInHouse(s, t, a, apples);
            var orangesCount = FruitsInHouse(s, t, b, oranges);
            Console.WriteLine(applesCount);
            Console.WriteLine(orangesCount);
        }

        private static int FruitsInHouse(int s, int t, int treePos, IEnumerable<int> fruits)
        {
            return fruits.Count(fruit => treePos + fruit >= s && treePos + fruit <= t);
        }

        public void Main(string[] args)
        {
            string[] st = Console.ReadLine().Split(' ');

            int s = Convert.ToInt32(st[0]);

            int t = Convert.ToInt32(st[1]);

            string[] ab = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(ab[0]);

            int b = Convert.ToInt32(ab[1]);

            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            int[] apple = Array.ConvertAll(Console.ReadLine().Split(' '), appleTemp => Convert.ToInt32(appleTemp))
                ;

            int[] orange = Array.ConvertAll(Console.ReadLine().Split(' '), orangeTemp => Convert.ToInt32(orangeTemp))
                ;
            countApplesAndOranges(s, t, a, b, apple, orange);
        }
    }
}