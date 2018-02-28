using System;

namespace MyHackerrankChallenges.Practice
{
    public class BirthdayChocolate : IChallenge
    {
        public void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] s_temp = Console.ReadLine().Split(' ');
            int[] s = Array.ConvertAll(s_temp, Int32.Parse);
            string[] tokens_d = Console.ReadLine().Split(' ');
            int d = Convert.ToInt32(tokens_d[0]);
            int m = Convert.ToInt32(tokens_d[1]);
            int result = solve(n, s, d, m);
            Console.WriteLine(result);
        }

        public int solve(int n, int[] s, int d, int m)
        {
            var result = 0;
            for (int i = 0; i <= n - m; i++)
            {
                var sum = 0;
                for (int j = i; j < i + m; j++)
                {
                    sum += s[j];
                    if (sum > d)
                    {
                        break;
                    }
                }
                if(sum == d)
                {
                    result++;
                }
            }
            return result;
        }
    }
}
