using System;
using System.Linq;

namespace MyHackerrankChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var challengeInstance = GetChallengeIntance();
                if (challengeInstance == null)
                {
                    Console.WriteLine("There are no challenges available.");
                    break;
                }
                else if (challengeInstance.Item1 == 0)
                {
                    return;
                }
                else if (challengeInstance.Item2 == null)
                {
                    Console.WriteLine("Challenge not found. Please, try again.");
                }
                else
                {
                    challengeInstance.Item2.Main(args);                    
                }
            }            
            Console.ReadKey();
        }

        private static Tuple<int, IChallenge> GetChallengeIntance()
        {
            var i = 0;
            var type = typeof(IChallenge);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && !p.IsInterface).ToList();
            if (types?.Count == 0)
            {
                return null;
            }
            Console.WriteLine("Enter the challenge code to start or 0 for exit.");
            PrintMenuOption(i++, "Exit");
            foreach (var item in types)
            {
                var challengeName = item.FullName.Replace(nameof(MyHackerrankChallenges) + '.', "");
                PrintMenuOption(i++, challengeName);                
            }
            var validRequest = int.TryParse(Console.ReadLine(), out int request) && request > 0 && request < i;
            
            if (!validRequest || request == 0)
            {
                return new Tuple<int, IChallenge>(request, null);
            }
            return new Tuple<int, IChallenge>(request, (IChallenge)Activator.CreateInstance(types[request - 1]));
        }

        private static void PrintMenuOption(int code, string option)
        {
            Console.WriteLine($"{code}- {option}");
        }
    }
}
