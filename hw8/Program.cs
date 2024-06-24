using NumberGenerators;

namespace hw8
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
            Console.WriteLine("Enter amount of numbers:");
            int amountOfNumbers = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose the generator: odd, even");
            string generatorType = Console.ReadLine();
            NumberGenerator numberGenerator;

            switch (generatorType)
            {
                case "odd":
                    numberGenerator = new OddNumberGenerator();
                    break;
                case "even":
                    numberGenerator = new EvenNumberGenerator();
                    break;
                default:
                    throw new ApplicationException($"Invalid generator type");
            }
        }
    }
}
