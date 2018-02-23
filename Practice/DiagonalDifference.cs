using System;

namespace MyHackerrankChallenges.Practice
{
    public class DiagonalDifference : IChallenge
    {
        public void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }
            Console.WriteLine(diagonalDiff(n, a));
            Console.ReadKey();
        }

        static int diagonalDiff(int n, int[][] m)
        {
            var primaryDiagSum = 0;
            var secondaryDiagSum = 0;
            var primaryIndex = 0;
            var secondaryIndex = n - 1;
            for (var i = 0; i < n; i++)
            {
                primaryDiagSum += m[i][primaryIndex++];
                secondaryDiagSum += m[i][secondaryIndex--];
            }
            return Math.Abs(primaryDiagSum - secondaryDiagSum);
        }
    }
}
