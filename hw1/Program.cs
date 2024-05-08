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
            InputArray(A);
            InputArray(B);
            int maxA = FindMax(A);
            int maxB = FindMax(B);
            int minA = FindMin(A);
            int minB = FindMin(B);
            int sum = SumArray(A) + SumArray(B);
            double multiplied = MultiplyArray(A) * MultiplyArray(B);
            int sumEvenA = SumEven(A);
            int sumOddB = SumOdd(B);
            Console.WriteLine($"Max Number: {maxA} {maxB}");
            Console.WriteLine($"Min Number: {minA} {minB}");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Multiplied: {multiplied}");
            Console.WriteLine($"Even Sum: {sumEvenA}");
            Console.WriteLine($"Obb B Sum: {sumOddB}");
            Console.ReadLine();
        }

        private static void InputArray(int[] array)
        {
            Console.WriteLine($"Input {array.Length} numbers:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        private static void InputArray(int[,] array)
        {
            Random rnd = new Random();
            Console.WriteLine("Array:");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(100);
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        private static int FindMax(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            return max;
        }

        private static int FindMax(int[,] array)
        {
            int max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                        max = array[i, j];
                }
            }
            return max;
        }

        private static int FindMin(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }
            return min;
        }

        private static int FindMin(int[,] array)
        {
            int min = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                        min = array[i, j];
                }
            }
            return min;
        }

        private static int SumArray(int[] array)
        {
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            return sum;
        }

        private static int SumArray(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
            }
            return sum;
        }

        private static double MultiplyArray(int[] array)
        {
            double result = 1;
            foreach (int num in array)
            {
                result *= num;
            }
            return result;
        }

        private static double MultiplyArray(int[,] array)
        {
            double result = 1;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    result *= array[i, j];
                }
            }
            return result;
        }

        private static int SumEven(int[] array)
        {
            int sum = 0;
            foreach (int num in array)
            {
                if (num % 2 == 0)
                    sum += num;
            }
            return sum;
        }

        private static int SumOdd(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] % 2 != 0)
                        sum += array[i, j];
                }
            }
            return sum;
        }

        private static void SolveTask2()
        {
            int[,] array = GenerateArray();
            int sum = CalculateSubMatrixSum(array);
            PrintArray(array);
            Console.WriteLine($"Sum: {sum}");
            Console.ReadLine();
        }

        private static int[,] GenerateArray()
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

            return array;
        }

        private static int CalculateSubMatrixSum(int[,] array)
        {
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

            int startRow = Math.Min(minRow, maxRow);
            int endRow = Math.Max(minRow, maxRow);
            int startColumn = Math.Min(minColumn, maxColumn);
            int endColumn = Math.Max(minColumn, maxColumn);

            int sum = 0;
            for (int i = startRow; i <= endRow; i++)
            {
                for (int j = startColumn; j <= endColumn; j++)
                {
                    sum += array[i, j];
                }
            }

            return sum;
        }

        private static void PrintArray(int[,] array)
        {
            Console.WriteLine("Array:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        private static void SolveTask3(string input)
        {
            string encryptedText = Encrypt(input);
            Console.WriteLine(encryptedText);
            string decryptedText = Decrypt(encryptedText);
            Console.WriteLine(decryptedText);
        }

        private static string Encrypt(string input)
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
            return encryptedText;
        }

        private static string Decrypt(string input)
        {
            string decryptedText = "";
            foreach (char c in input)
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
            return decryptedText;
        }

        private static void SolveTask4()
        {
            int[,] array = GenerateRandomArray();
            PrintArray(array);
            int operation = ChooseOperation();
            PerformOperation(array, operation);
        }

        private static int[,] GenerateRandomArray()
        {
            Random rnd = new Random();
            int[,] array = new int[2, 4];
            Console.WriteLine("Array:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    array[i, j] = rnd.Next(100);
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
            return array;
        }

        private static int ChooseOperation()
        {
            Console.WriteLine("Choose Operation:");
            Console.WriteLine("1 Multiply by Number");
            Console.WriteLine("2 Add");
            Console.WriteLine("3 Multiply");
            return int.Parse(Console.ReadLine());
        }

        private static void PerformOperation(int[,] array, int operation)
        {
            switch (operation)
            {
                case 1:
                    MultiplyByNumber(array);
                    break;
                case 2:
                    AddArrays(array);
                    break;
                case 3:
                    MultiplyArrays(array);
                    break;
                default:
                    Console.WriteLine("Invalid Operation");
                    break;
            }
        }

        private static void MultiplyByNumber(int[,] array)
        {
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
            PrintArray(result);
        }

        private static void AddArrays(int[,] array)
        {
            int[] result = new int[4];
            for (int j = 0; j < 4; j++)
            {
                result[j] = array[0, j] + array[1, j];
            }
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"{result[i]} ");
            }
        }

        private static void MultiplyArrays(int[,] array)
        {
            int[] result = new int[4];
            for (int j = 0; j < 4; j++)
            {
                result[j] = array[0, j] * array[1, j];
            }
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"{result[i]} ");
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
