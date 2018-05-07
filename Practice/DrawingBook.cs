using System;

namespace MyHackerrankChallenges.Practice
{
    public class DrawingBook : IChallenge
    {
        public void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var p = Convert.ToInt32(Console.ReadLine());
            var result = PageTurns(n, p);
            Console.WriteLine(result);
        }

        private static int PageTurns(int n, int p)
        {
            var startFromFront = n / 2 >= p;
            if (startFromFront)
            {
                return p / 2;
            }
            return n % 2 != 0 ? (n - p) / 2 : (n - p + 1) / 2;
        }
    }
}