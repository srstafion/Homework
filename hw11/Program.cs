using System;

namespace hw11
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
            Console.Write("Choose a character: ");
            char character = char.Parse(Console.ReadLine());

            Console.Write("Choose amount of lines: ");
            int lines = int.Parse(Console.ReadLine());

            Action<char> generateLine = lambdaEven();
            generateLine += lambdaOdd();

            for (int i = 0; i < lines; i++)
            {
                generateLine(character);
                Console.WriteLine();
            }
        }
        private static Action<char> lambdaEven()
        {
            return symbol =>
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.Write(i % 2 == 0 ? symbol : ' ');
                }
            };
        }

        private static Action<char> lambdaOdd()
        {
            return symbol =>
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.Write(i % 2 != 0 ? symbol : ' ');
                }
            };
        }
    }
}