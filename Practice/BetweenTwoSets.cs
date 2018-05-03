using System;
using System.Linq;

namespace MyHackerrankChallenges.Practice
{
    public class BetweenTwoSets : IChallenge
    {
        /*
     * Complete the getTotalX function below.
     */
        static int getTotalX(int[] a, int[] b)
        {
            var maxA = a.Max();
            var minB = b.Min();
            int total = 0, j;
            for (var i = maxA; i <= minB; i++)
            {
                var aCheck = 0;
                for (j = 0; j < a.Length; j++)
                {
                    if (i % a[j] == 0)
                    {
                        aCheck++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (aCheck != a.Length)
                {
                    continue;
                }
                var bCheck = 0;
                for (j = 0; j < b.Length; j++)
                {
                    if (b[j] % i == 0)
                    {
                        bCheck++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (bCheck != b.Length)
                {
                    continue;
                }
                total++;
            }
            return total;

        }

        
        public void Main(string[] args)
        {
            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);

            int m = Convert.ToInt32(nm[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
                ;

            int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), bTemp => Convert.ToInt32(bTemp))
                ;
            int total = getTotalX(a, b);

            Console.WriteLine(total);
        }
    }
}
