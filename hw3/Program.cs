using System.Xml.Linq;

namespace hw3
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
            Console.WriteLine("Choose operation:");
            Console.WriteLine("1. Decimal to binary");
            Console.WriteLine("2. Binary to Decimal");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: DecimalToBinary(); break;
                case 2: BinaryToDecimal(); break;
                default: Console.WriteLine("Unknown task"); break;
            }
        }

        static void DecimalToBinary()
        {
            try
            {
                Console.WriteLine("Input decimal:");
                int decimalNumber = int.Parse(Console.ReadLine());

                string binaryNumber = Convert.ToString(decimalNumber, 2);
                Console.WriteLine($"{binaryNumber}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect format");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Out of bounds");
            }
        }

        static void BinaryToDecimal()
        {
            try
            {
                Console.WriteLine("Input binary number");
                string binaryNumberStr = Console.ReadLine();

                if (!IsBinaryNumber(binaryNumberStr))
                {
                    Console.WriteLine("incorrect format");
                    return;
                }

                int decimalNumber = Convert.ToInt32(binaryNumberStr, 2);
                Console.WriteLine($"{decimalNumber}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect format");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Out of bounds");
            }
        }

        static bool IsBinaryNumber(string str)
        {
            foreach (char c in str)
            {
                if (c != '0' && c != '1')
                    return false;
            }
            return true;
        }

        private static int ConvertWordToDigit(string word)
        {
            switch (word.ToLower())
            {
                case "zero":
                    return 0;
                case "one":
                    return 1;
                case "two":
                    return 2;
                case "three":
                    return 3;
                case "four":
                    return 4;
                case "five":
                    return 5;
                case "six":
                    return 6;
                case "seven":
                    return 7;
                case "eight":
                    return 8;
                case "nine":
                    return 9;
                default:
                    throw new ArgumentException("Invalid word");
            }
        }

        private static void SolveTask2()
        {
            Console.WriteLine("Enter a word digit:");
            string word = Console.ReadLine();
            try
            {
                int digit = ConvertWordToDigit(word);
                Console.WriteLine($"{digit}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        class Passport
        {
            private int passportNumber;
            private string fullName;
            private int issueDate;

            public Passport(int passportNumber, string fullName, int issueDate)
            {
                this.passportNumber = passportNumber;
                this.fullName = fullName;
                this.issueDate = issueDate;
            }

            public int PassportNumber
            {
                get { return passportNumber; }
            }

            public string FullName
            {
                get { return fullName; }
            }

            public int IssueDate
            {
                get { return issueDate; }
            }
        }

        private static void SolveTask3()
        {
            try
            {
                Passport passport = new Passport(123456, "John Doe", 2022);
                Console.WriteLine("Passport created:");
                Console.WriteLine($"Passport Number: {passport.PassportNumber}");
                Console.WriteLine($"Full Name: {passport.FullName}");
                Console.WriteLine($"Issue Date: {passport.IssueDate}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating passport: {ex.Message}");
            }
        }

        private static void SolveTask4()
        {
            Console.WriteLine("Input equation:");
            string input = Console.ReadLine();
            try
            {
                bool result = EvaluateExpression(input);
                Console.WriteLine($"{result}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }

        static bool EvaluateExpression(string expression)
        {
            string[] parts = expression.Split(new char[] { '>', '<', '=', '!' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length != 2)
            {
                throw new ArgumentException("Incorrect format");
            }
            int operand1, operand2;
            if (!int.TryParse(parts[0].Trim(), out operand1) || !int.TryParse(parts[1].Trim(), out operand2))
            {
                throw new ArgumentException("Incorrect formatв");
            }

            char op = expression[parts[0].Length];
            switch (op)
            {
                case '>':
                    return operand1 > operand2;
                case '<':
                    return operand1 < operand2;
                case '=':
                    return operand1 == operand2;
                case '!':
                    return operand1 != operand2;
                default:
                    throw new ArgumentException("Неверный оператор");
            }
        }
    }
}
