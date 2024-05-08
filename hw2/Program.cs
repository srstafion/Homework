using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace hw2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 6, -1, 88, 7, 6 };
            int[] array2 = { 6, 88, 7 };
            Console.WriteLine("Enter task number:");
            int taskNumber = int.Parse(Console.ReadLine());
            switch (taskNumber)
            {
                case 1: SolveTask1(); break;
                case 2: SolveTask2(); break;
                case 3: SolveTask3(array1, array2); break;
                case 4: SolveTask4(); break;
                case 5: SolveTask5(); break;
                case 6: SolveTask6(); break;
                default: Console.WriteLine("Unknown task"); break;
            }
        }
        private static void SolveTask1()
        {
            Console.Write("Enter size: ");
            int size = int.Parse(Console.ReadLine());
            Console.Write("Enter symbol: ");
            char symbol = char.Parse(Console.ReadLine());

            PrintSquare(size, symbol);
        }

        private static void PrintSquare(int size, char symbol)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(symbol + " ");
                }
                Console.WriteLine();
            }
        }

        private static void SolveTask2()
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            bool isPalindrome = CheckPalindrome(number);
            Console.WriteLine(isPalindrome);
        }

        private static bool CheckPalindrome(int number)
        {
            string numString = number.ToString();
            int rightIndex = numString.Length - 1;

            for (int i = 0; i < numString.Length / 2; i++)
            {
                if (numString[i] != numString[rightIndex - i])
                    return false;
            }
            return true;
        }

        private static void SolveTask3(int[] array1, int[] array2)
        {
            int[] resultArray = RemoveCommonElements(array1, array2);
            PrintIntArray(resultArray);
        }

        private static int[] RemoveCommonElements(int[] array1, int[] array2)
        {
            int count = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        count++;
                        array1[i] = 0;
                        break;
                    }
                }
            }

            int[] newArr = new int[array1.Length - count];
            count = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != 0) newArr[count++] = array1[i];
            }

            return newArr;
        }

        private static void PrintIntArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

    class Website
        {
            public string Name { get; set; }
            public string Url { get; set; }
            public string Description { get; set; }
            public string Ip { get; set; }

            public void EnterData()
            {
                Console.Write("Set Site Name: ");
                Name = Console.ReadLine();

                Console.Write("Set Url: ");
                Url = Console.ReadLine();

                Console.Write("Set Description: ");
                Description = Console.ReadLine();

                Console.Write("Set IP: ");
                Ip = Console.ReadLine();
            }

            public void DisplayData()
            {
                Console.WriteLine("Site Name: " + Name);
                Console.WriteLine("URL: " + Url);
                Console.WriteLine("Description: " + Description);
                Console.WriteLine("IP: " + Ip);
            }
        }

        private static void SolveTask4()
        {
            Website website = new Website();
            website.EnterData();
            Console.WriteLine();
            website.DisplayData();
        }

        class Magazine
        {
            public string Name { get; set; }
            public string ReleaseYear { get; set; }
            public string Description { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }

            public void EnterData()
            {
                Console.Write("Set Magazine Name: ");
                Name = Console.ReadLine();

                Console.Write("Set Release Year: ");
                ReleaseYear = Console.ReadLine();

                Console.Write("Set Description: ");
                Description = Console.ReadLine();

                Console.Write("Set Phone Number: ");
                Phone = Console.ReadLine();

                Console.Write("Set Email: ");
                Email = Console.ReadLine();
            }

            public void DisplayData()
            {
                Console.WriteLine("Magazine Name: " + Name);
                Console.WriteLine("Release Year: " + ReleaseYear);
                Console.WriteLine("Description: " + Description);
                Console.WriteLine("Phone: " + Phone);
                Console.WriteLine("Email: " + Email);
            }
        }

        private static void SolveTask5()
        {
            Magazine magazine = new Magazine();
            magazine.EnterData();
            Console.WriteLine();
            magazine.DisplayData();
        }

        class Shop
        {
            public string Name { get; set; }
            public string Address { get; set; }
            public string Description { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }

            public void EnterData()
            {
                Console.Write("Set Shop Name: ");
                Name = Console.ReadLine();

                Console.Write("Set Address: ");
                Address = Console.ReadLine();

                Console.Write("Set Description: ");
                Description = Console.ReadLine();

                Console.Write("Set Phone Number: ");
                Phone = Console.ReadLine();

                Console.Write("Set Email: ");
                Email = Console.ReadLine();
            }

            public void DisplayData()
            {
                Console.WriteLine("Shop Name: " + Name);
                Console.WriteLine("Address: " + Address);
                Console.WriteLine("Description: " + Description);
                Console.WriteLine("Phone: " + Phone);
                Console.WriteLine("Email: " + Email);
            }
        }

        private static void SolveTask6()
        {
            Shop shop = new Shop();
            shop.EnterData();
            Console.WriteLine();
            shop.DisplayData();
        }
    }
}
