using System;

namespace MyHackerrankChallenges.Practice
{
    class BirthdayCakeCandles : IChallenge
    {
        private static int birthdayCakeCandles(int n, int[] ar)
        {
            // Complete this function
            var tallerCandle = ar[0];
            var result = 1;
            for (var i = 1; i < ar.Length; i++)
            {
                if (ar[i] == tallerCandle)
                {
                    result++;
                }
                else if (ar[i] > tallerCandle)
                {
                    tallerCandle = ar[i];
                    // reset count
                    result = 1;
                }
            }

            return result;
        }

        public void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = birthdayCakeCandles(n, ar);
            Console.WriteLine(result);
        }
    }
}
