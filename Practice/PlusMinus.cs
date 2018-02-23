using System;

namespace MyHackerrankChallenges.Practice
{
    public class PlusMinus : IChallenge
    {
        public void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            Console.WriteLine(String.Join("\n", plusMinus(n, arr)));
            Console.ReadKey();
        }

        static double[] plusMinus(int n, int[] arr)
        {
            var result = new double[] { 0, 0, 0 };
            for (var i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                {
                    result[0]++;
                }
                else if (arr[i] < 0)
                {
                    result[1]++;
                }
                else
                {
                    result[2]++;
                }
            }
            for (var i = 0; i < result.Length; i++)
            {
                result[i] /= n;
            }
            return result;
        }
    }
}
