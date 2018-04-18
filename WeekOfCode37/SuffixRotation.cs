using System;
using System.Text;

namespace MyHackerrankChallenges.WeekOfCode37
{
    public class SuffixRotation : IChallenge
    {
        public void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < q; a0++)
            {
                string s = Console.ReadLine();
                Console.WriteLine(suffixRotation(s));
            }
        }

        private static int suffixRotation(string s)
        {
            var result = 0;
            var index = 0;
            while (!isLexicographicallySmallest(s))
            {
                if (index + 1 >= s.Length)
                {
                    index = 0;
                }
                if (s[index + 1] < s[index])
                {
                    s = rotateSuffix(s, index);
                    result++;
                }
                index++;
            }
            return result;
        }

        private static string rotateSuffix(string s, int index)
        {
            var firstChar = s[index];
            var lastChar = s[s.Length - 1];

            var lastSubstr = s.Substring(index + 1, s.Length - index - 1);

            var aStringBuilder = new StringBuilder();
            aStringBuilder.Append(s.Substring(0, index));            
            aStringBuilder.Append(lastSubstr);
            aStringBuilder.Append(firstChar);
            return aStringBuilder.ToString();
        }

        private static bool isLexicographicallySmallest(string s)
        {
            if (s?.Length == 0)
            {
                return true;
            }
            var minor = s[0];
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] < minor)
                {
                    return false;
                }
                minor = s[i];
            }
            return true;
        }
    }
}