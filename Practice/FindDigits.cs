using System;

namespace MyHackerrankChallenges.Practice
{
    public class FindDigits : IChallenge
    {
        public void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int result = findDigits(n);
                Console.WriteLine(result);
            }
        }

        static int findDigits(int n)
        {
            var digitsStr = n.ToString();
            var result = 0;
            foreach (var item in digitsStr)
            {
                var digit = int.Parse(item.ToString());
                if (digit == 0)
                {
                    continue;
                }
                if (n % digit == 0)
                {
                    result++;
                }
            }
            return result;
        }

    }
}
