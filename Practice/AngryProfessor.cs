using System;
using System.Linq;

namespace MyHackerrankChallenges.Practice
{
    public class AngryProfessor : IChallenge
    {
        public void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int k = Convert.ToInt32(tokens_n[1]);
                string[] a_temp = Console.ReadLine().Split(' ');
                int[] a = Array.ConvertAll(a_temp, Int32.Parse);
                string result = angryProfesor(k, a);
                Console.WriteLine(result);
            }
        }

        private static string angryProfesor(int k, int[] a)
        {
            return a.Where(t => t <= 0).Count() >= k ? "NO" : "YES";
        }
    }
}
