using System;
using System.Linq;

namespace MyHackerrankChallenges.Booking
{
    public class SupportOperators : IChallenge
    {
        public void Main(string[] args)
        {
            var currentOperatorCount = int.Parse(Console.ReadLine());
            var rangesCount = int.Parse(Console.ReadLine());
            var ranges = new int[rangesCount][];
            for (var i = 0; i < rangesCount; i++)
            {
                var sRange = Console.ReadLine()?.Split(' ');
                ranges[i] = sRange?.Select(int.Parse).ToArray();
            }
            var result = OperatorsNeeded(currentOperatorCount, ranges);
            Console.WriteLine(result);
        }

        public static int OperatorsNeeded(int currentOperatorCount, int[][] ranges)
        {
            ranges = ranges.OrderBy(r => r[0]).ToArray();
            var lastRange = ranges[0];
            var result = 0;
            for (var i = 1; i < ranges.Length; i++)
            {
                if (ranges[i][0] < lastRange[1])
                {
                    result++;
                }
                if (ranges[i][1] > lastRange[1])
                {
                    lastRange = ranges[i];
                }
            }
            return result > currentOperatorCount ? result - currentOperatorCount : 0;
        }
    }
}