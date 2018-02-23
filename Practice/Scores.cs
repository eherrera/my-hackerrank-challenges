using System;

namespace MyHackerrankChallenges.Practice
{
    public class Scores : IChallenge
    {
        public void Main(string[] args)
        {
            Console.ReadLine();
            string[] s_temp = Console.ReadLine().Split(' ');
            int[] s = Array.ConvertAll(s_temp, Int32.Parse);
            int[] result = getRecord(s);
            Console.WriteLine(String.Join(" ", result));
            Console.ReadKey();
        }

        static int[] getRecord(int[] s)
        {
            // Complete this function
            var hScore = s[0];
            var lScore = s[0];
            var result = new[] { 0, 0 };
            for (var i = 1; i < s.Length; i++)
            {
                if (s[i] > hScore)
                {
                    hScore = s[i];
                    result[0]++;
                }
                if (s[i] < lScore)
                {
                    lScore = s[i];
                    result[1]++;
                }
            }
            return result;
        }
    }
}
