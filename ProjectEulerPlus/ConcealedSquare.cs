using System;
using System.Numerics;
using System.Linq;
using MyHackerrankChallenges.Helpers;

namespace MyHackerrankChallenges.ProjectEulerPlus
{
    public class ConcealedSquare : IChallenge
    {
        public void Main(string[] args)
        {
            var numberOfKnowDigits = int.Parse(Console.ReadLine());
            var digits = Console.ReadLine();
            var result = GetConcealedSquare2(numberOfKnowDigits, digits.Split(' '));
            Console.WriteLine(result);  
        }

        private static BigInteger GetConcealedSquare2(int numberOfKnowDigits, string[] digits)
        {
            var minValidInteger = BigInteger.Parse(string.Join("0", digits));
            var maxValidInteger = BigInteger.Parse(string.Join("9", digits));
            var startAsc = int.Parse(digits[0]) < 5;
            var minValidIntegerRoot = startAsc ? minValidInteger.Sqrt() : maxValidInteger.Sqrt();
            // Squares of even numbers are always even numbers and square of odd numbers are always odd. 
            //var onlyEven = int.Parse(digits[digits.Length - 1]) % 2 == 0;
            //if (onlyEven && minValidIntegerRoot % 2 != 0)
            //{
            //    minValidIntegerRoot++;
            //}
            BigInteger seq = 0;
            do
            {
                seq = minValidIntegerRoot * minValidIntegerRoot;
                if (ValidSequence(seq, digits))
                {
                    return minValidIntegerRoot;
                }
                if ((startAsc && seq > maxValidInteger) || (!startAsc && seq <= minValidInteger))
                {
                    return 0;
                }
                
                minValidIntegerRoot += startAsc ? 1 : -1;

            }
            while (true);
        }        
        

        private static bool ValidSequence(BigInteger sequence, string[] digits)
        {            
            var strSeq = sequence.ToString();
            int j = 0;
            for (int i = 0; i < strSeq.Length; i+=2)
            {
                if(strSeq[i].ToString() != digits[j++])
                {
                    return false;
                }
            }
            return true;
        }

        private static long GetConcealedSquare(int numberOfKnowDigits, string[] digits)
        {
            //no square number ends in 2, 3, 7 or 8. 
            if (new int[] { 2, 3, 7, 8 }.Any(d => digits[digits.Length - 1].EndsWith(d.ToString())))
            {
                return 0;
            }
            long? lastSeq = null;
            var maxSeq = int.Parse("9".PadLeft(digits.Length, '9'));
            do
            {
                var nextSeq = NextIntSequence(digits, lastSeq);
                if (PerfectSquare(nextSeq.Item1))
                {
                    return Convert.ToInt64(Math.Sqrt(nextSeq.Item1));
                }
                lastSeq = nextSeq.Item2;
            }
            while (lastSeq < maxSeq);
            return 0;
        }

        private static bool PerfectSquare(long number)
        {
            var d = Math.Sqrt(number);
            return d % 1 == 0;
        }

        private static Tuple<long, long> NextIntSequence(string[] digits, long? lastSequence = null)
        {
            long nextLong = 0;
            if (lastSequence.HasValue)
            {
                nextLong = lastSequence.Value + 1;
            }
            var seqLength = digits.Length - 1;
            var seq = nextLong.ToString().PadLeft(seqLength, '0');
            var result = "";
            for (int i = 0; i < digits.Length; i++)
            {
                result += digits[i];
                if (seq.Length > 0)
                {
                    result += seq[0];
                    seq = seq.Remove(0, 1);                    
                }
            }
            var r = long.Parse(result);
            //perfect square leaves remainder 0 or 1 on division by 3.
            if (r % 3 > 1)
            {
                return NextIntSequence(digits, nextLong);
            }
            return new Tuple<long, long>(r, nextLong);
        }
    }
}
