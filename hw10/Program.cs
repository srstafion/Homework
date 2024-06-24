using TextSearch;

namespace hw10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter task number:");
            int taskNumber = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (taskNumber)
            {
                case 1: SolveTask1(); break;
                default: Console.WriteLine("Unknown task"); break;
            }
        }

        private static void SolveTask1()
        {
            Console.WriteLine("Input text: ");
            string text = Console.ReadLine();

            Console.WriteLine("Search for...");
            Console.WriteLine("1. Your words");
            Console.WriteLine("2. Forbidden words");

            int taskNumber = int.Parse(Console.ReadLine());

            ProblemFinder problemFinder = null;

            switch (taskNumber)
            {
                case 1:
                    Console.Write("Enter how custom words you have: ");
                    int wordsCount = int.Parse(Console.ReadLine());
                    string[] words = new string[wordsCount];

                    for (int i = 0; i < wordsCount; i++)
                    {
                        Console.Write($"Word number {i + 1}: ");
                        words[i] = Console.ReadLine();
                    }

                    problemFinder = new CustomWordFinder(text, words);
                    break;

                case 2:
                    problemFinder = new ForbiddenWordFinder(text);
                    break;

                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }

            if (problemFinder != null)
            {
                Dictionary<string, int> result = problemFinder.FindProblem();
                var value = result.Keys;
                foreach (string key in value)
                {
                    Console.WriteLine("Word: " + key + " Found: " + result[key]);
                }
            }
        }
    }
}
