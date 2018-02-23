using System;

namespace MyHackerrankChallenges.Practice
{
    public class StairCase : IChallenge
    {
        public void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            staircase(n);
            Console.ReadKey();
        }

        static void staircase(int n)
        {
            int symbolCount = 1;
            for (var spaceCount = n - 1; spaceCount >= 0; spaceCount--)
            {
                Console.WriteLine(buildStep(spaceCount, symbolCount++));
            }
        }

        static string buildStep(int spaceCount, int symbolCount)
        {
            var result = "";
            var total = symbolCount + spaceCount;
            for (var i = 0; i < total; i++)
            {
                if (spaceCount-- > 0)
                {
                    result += ' ';
                }
                else if (symbolCount-- > 0)
                {
                    result += '#';
                }
            }
            return result;
        }
    }
}
