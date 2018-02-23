using System;

namespace MyHackerrankChallenges.Practice
{
    public class CompareTheTriplets : IChallenge
    {
        static int[] solve(int a0, int a1, int a2, int b0, int b1, int b2)
        {
            // Complete this function
            var result = new int[2];
            result[0] = pointsOf(true, a0, b0) + pointsOf(true, a1, b1) + pointsOf(true, a2, b2);
            result[1] = pointsOf(false, a0, b0) + pointsOf(false, a1, b1) + pointsOf(false, a2, b2);
            return result;
        }

        static int pointsOf(bool alice, int a, int b)
        {
            if (alice)
            {
                return a > b ? 1 : 0;
            }
            return b > a ? 1 : 0;
        }

        public void Main(String[] args)
        {
            string[] tokens_a0 = Console.ReadLine().Split(' ');
            int a0 = Convert.ToInt32(tokens_a0[0]);
            int a1 = Convert.ToInt32(tokens_a0[1]);
            int a2 = Convert.ToInt32(tokens_a0[2]);
            string[] tokens_b0 = Console.ReadLine().Split(' ');
            int b0 = Convert.ToInt32(tokens_b0[0]);
            int b1 = Convert.ToInt32(tokens_b0[1]);
            int b2 = Convert.ToInt32(tokens_b0[2]);
            int[] result = solve(a0, a1, a2, b0, b1, b2);
            Console.WriteLine(String.Join(" ", result));
            Console.ReadKey();
        }
    }
}
