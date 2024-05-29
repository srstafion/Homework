using hw5.GuessingGames;
using hw5.NumberGenerators;
using hw5.ShapeDrawers;
using hw5.TextGenerators;

namespace hw5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter task number:");
            int taskNumber = int.Parse(Console.ReadLine());
            switch (taskNumber)
            {
                case 1: SolveTask1(); break;
                case 2: SolveTask2(); break;
                case 3: SolveTask3(); break;
                case 4: SolveTask4(); break;
                default: Console.WriteLine("Unknown task"); break;
            }
        }
        private static void SolveTask1()
        {
            Console.WriteLine("1. Even 2. Odd 3. Prime 4. Fibonacci");

            int choice = int.Parse(Console.ReadLine());
            var evenGenerator = new EvenNumberGenerator();
            var oddGenerator = new OddNumberGenerator();
            var primeGenerator = new PrimeNumberGenerator();
            var fibonacciGenerator = new FibonacciNumberGenerator();
            switch (choice)
            {
                case 1: Console.WriteLine(evenGenerator.Generate()); break;
                case 2: Console.WriteLine(oddGenerator.Generate()); break;
                case 3: Console.WriteLine(primeGenerator.Generate()); break;
                case 4: Console.WriteLine(fibonacciGenerator.Generate()); break;
                default: Console.WriteLine("Unknown task"); break;
            }
        }
        private static void SolveTask2()
        {
            Console.WriteLine("1. Triangle 2. Rectangle 3. Square");

            var triangleDrawer = new TriangleDrawer();
            var rectangleDrawer = new RectangleDrawer();
            var squareDrawer = new SquareDrawer();
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Input Triangle Height");
                    int Theight = int.Parse(Console.ReadLine());
                    triangleDrawer.Draw(Theight); 
                    break;
                case 2:
                    Console.WriteLine("Input Redctangle Width");
                    int Rwidth = int.Parse(Console.ReadLine());
                    Console.WriteLine("Input Rectangle Height");
                    int Rheight = int.Parse(Console.ReadLine());
                    rectangleDrawer.Draw(Rwidth, Rheight); 
                    break;
                case 3:
                    Console.WriteLine("Input Square Side");
                    int Sside = int.Parse(Console.ReadLine());
                    squareDrawer.Draw(Sside); 
                    break;
                default: Console.WriteLine("Unknown task"); break;
            }
        }
        private static void SolveTask3()
        {
            Console.Write("Enter the start of the range: ");
            int min = int.Parse(Console.ReadLine());

            Console.Write("Enter the end of the range: ");
            int max = int.Parse(Console.ReadLine());

            if (min > max) (min, max) = (max, min);

            GuessTheNumber game = new GuessTheNumber(min, max);
            game.Play();
        }
        private static void SolveTask4()
        {
            Console.Write("Enter the number of vowels: ");
            int numVowels = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of consonants: ");
            int numConsonants = int.Parse(Console.ReadLine());
            Console.Write("Enter the maximum word length: ");
            int maxWordLength = int.Parse(Console.ReadLine());

            PsuedoTextGenerator generator = new PsuedoTextGenerator(numVowels, numConsonants, maxWordLength);
            string pseudoText = generator.GenerateText();

            Console.WriteLine("Generated Pseudo Text:");
            Console.WriteLine(pseudoText);
        }
    }
}
