using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHackerrankChallenges.Practice
{
    public class Kangaroo : IChallenge
    {
        public void Main(string[] args)
        {
            string[] tokens_x1 = Console.ReadLine().Split(' ');
            int x1 = Convert.ToInt32(tokens_x1[0]);
            int v1 = Convert.ToInt32(tokens_x1[1]);
            int x2 = Convert.ToInt32(tokens_x1[2]);
            int v2 = Convert.ToInt32(tokens_x1[3]);
            string result = kangaroo(x1, v1, x2, v2);
            Console.WriteLine(result);
        }

        private static string kangaroo(int x1, int v1, int x2, int v2)
        {
            /*
             x - numero de salto
             y - posicion al finalizar el salto

             y = 3x + 0
             y = 2x + 4
             3x = 2x + 4 ...
             */
            if (v1 - v2 == 0)
            {
                return "NO";
            }
            decimal x = Decimal.Divide(x2 - x1, v1 - v2);
            decimal y = x * v1 + x1;
            var max = x1 > x2 ? x1 : x2;
            return IsInteger(y) && y >= max ? "YES" : "NO";            
        }

        private static bool IsInteger(decimal d)
        {
            return d % 1 == 0;
        }
    }
}
