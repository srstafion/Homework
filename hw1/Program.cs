using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace hw1
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
                case 3: SolveTask3("Test"); break;
                case 4: SolveTask4(); break;
                case 5: 
                    SolveTask5("5+3");
                    SolveTask5("5-3");
                    break;
                case 6: SolveTask6("this is a sentence. this is the second sentence"); break;
                case 7: SolveTask7("this is a sentence. this is the second sentence"); break;
                default: Console.WriteLine("Unknown task"); break;
            }
        }
        private static void SolveTask1()
        {
            int[] A = new int[5];
            int[,] B = new int[3, 4];
            Console.WriteLine("Input 5 numbers for array A:");
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Array A:");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"{A[i]} ");
            }
            Console.WriteLine();

            Random rnd = new Random();
            Console.WriteLine("Array B:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    B[i, j] = rnd.Next(100);
                    Console.Write($"{B[i, j]} ");
                }
                Console.WriteLine();
            }

            int maxA = A[0];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > maxA) maxA = A[i];
            }

            int maxB = B[0, 0];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (B[i, j] > maxB) maxB = B[i, j];
                }
            }
            Console.WriteLine($"Max Number: {maxA} {maxB}");

            int minA = A[0];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < minA) minA = A[i];
            }

            int minB = B[0, 0];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (B[i, j] < minB) minB = B[i, j];
                }
            }
            Console.WriteLine($"Min Number: {minA} {minB}");

            int sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i];
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sum += B[i, j];
                }
            }
            Console.WriteLine($"Sum: {sum}");

            double multiplied = 1;
            for (int i = 0; i < A.Length; i++)
            {
                multiplied *= A[i];
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    multiplied *= B[i, j];
                }
            }
            Console.WriteLine($"Multiplied: {multiplied}");

            int sumEvenA = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                    sumEvenA += A[i];
            }
            Console.WriteLine($"Even Sum: {sumEvenA}");

            int sumOddB = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (B[i, j] % 2 != 0)
                    {
                        sumOddB += B[i, j];
                    }
                }
            }
            Console.WriteLine($"Obb B Sum: {sumOddB}");
            Console.ReadLine();
        }

        private static void SolveTask2()
        {
            int[,] array = new int[5, 5];
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = rnd.Next(-100, 101);
                }
            }

            int minElement = array[0, 0];
            int maxElement = array[0, 0];
            int minRow = 0, minColumn = 0;
            int maxRow = 0, maxColumn = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (array[i, j] < minElement)
                    {
                        minElement = array[i, j];
                        minRow = i;
                        minColumn = j;
                    }

                    if (array[i, j] > maxElement)
                    {
                        maxElement = array[i, j];
                        maxRow = i;
                        maxColumn = j;
                    }
                }
            }

            int startRow = minRow < maxRow ? minRow : maxRow;
            int endRow = minRow > maxRow ? minRow : maxRow;
            int startColumn = minColumn < maxColumn ? minColumn : maxColumn;
            int endColumn = minColumn > maxColumn ? minColumn : maxColumn;

            int sum = 0;
            for (int i = startRow; i <= endRow; i++)
            {
                for (int j = startColumn; j <= endColumn; j++)
                {
                    sum += array[i, j];
                }
            }

            Console.WriteLine("Array:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Sum: {sum}");
            Console.ReadLine();
        }

        private static void SolveTask3(string input)
        {
            string encryptedText = "";
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    char shiftedChar = (char)(((c - 'a' + 3) % 26) + 'a');
                    encryptedText += shiftedChar;
                }
                else
                {
                    encryptedText += c;
                }
            }
            Console.WriteLine(encryptedText);
            string decryptedText = "";
            foreach (char c in encryptedText)
            {
                if (char.IsLetter(c))
                {
                    char shiftedChar = (char)(((c - 'a' - 3) % 26) + 'a');
                    decryptedText += shiftedChar;
                }
                else
                {
                    decryptedText += c;
                }
            }
            Console.WriteLine(decryptedText);
        }

        private static void SolveTask4()
        {
            Random rnd = new Random();
            int[,] array = new int[2, 4];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    array[i, j] = rnd.Next(100);
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Choose Operation:");
            Console.WriteLine("1 Multiply by Number");
            Console.WriteLine("2 Add");
            Console.WriteLine("3 Multiply");
            int taskNumber = int.Parse(Console.ReadLine());

            switch (taskNumber)
            {
                case 1:
                    Console.WriteLine("Pick a Number:");
                    int num = Convert.ToInt32(Console.ReadLine());
                    int[,] result = new int[2, 4];
                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            result[i, j] = array[i, j] * num;
                        }
                    }
                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            Console.Write($"{result[i, j]} ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    int[] result2 = new int[4];
                    for (int j = 0; j < 4; j++)
                    {
                        result2[j] = array[0, j] + array[1, j];
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        Console.Write($"{result2[i]} ");
                    }
                    break;
                case 3:
                    int[] result3 = new int[4];
                    for (int j = 0; j < 4; j++)
                    {
                        result3[j] = array[0, j] * array[1, j];
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        Console.Write($"{result3[i]} ");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Operation");
                    break;
            }
        }

        private static void SolveTask5(string equation)
        {
            char[] operators = { '+', '-' };
            string[] parts = equation.Split(operators);
            int result = int.Parse(parts[0]);
            for (int i = 1; i < parts.Length; i++)
            {
                char operation = equation[result.ToString().Length];
                int number = int.Parse(parts[i]);
                switch (operation)
                {
                    case '+':
                        result += number;
                        break;
                    case '-':
                        result -= number;
                        break;
                }
            }
            Console.WriteLine(result);
        }
        private static void SolveTask6(string sentence)
        {
            string[] sentences = Regex.Split(sentence, @"(?<=[\.!\?])\s+");

            for (int i = 0; i < sentences.Length; i++)
            {
                sentences[i] = char.ToUpper(sentences[i][0]) + sentences[i].Substring(1);
            }
            string result = string.Join(" ", sentences);
            Console.WriteLine(result);

        }

        private static void SolveTask7(string input)
        {
            string[] bannedWords = { "this" };
            string censoredText = input;

            foreach (string word in bannedWords)
            {
                censoredText = censoredText.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(censoredText);
        }
    }
}
