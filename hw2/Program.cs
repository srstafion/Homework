using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace hw1
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
                case 1: SolveTask1(5, '#'); break;
                case 2: 
                    SolveTask2(1234);
                    SolveTask2(1221);
                    break;
                case 3: SolveTask3(array1, array2); break;
                case 4: SolveTask4(); break;
                case 5: SolveTask5(); break;
                case 6: SolveTask6(); break;
                default: Console.WriteLine("Unknown task"); break;
            }
        }
        private static void SolveTask1(int size, char symbol)
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

        private static void SolveTask2(int number)
        {
            string numString = number.ToString();
            int rightIndex = numString.Length - 1;

            for (int i = 0; i < numString.Length / 2; i++)
            {
                Console.WriteLine(numString[i] != numString[rightIndex - i]);
                break;
            }
        }

        private static void SolveTask3(int[] array1, int[] array2)
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

            foreach (int num in newArr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        class Website
        {
            private string name;
            private string url;
            private string description;
            private string ip;

            public void SetName(string name)
            {
                this.name = name;
            }

            public string GetName()
            {
                return name;
            }

            public void SetUrl(string url)
            {
                this.url = url;
            }

            public string GetUrl()
            {
                return url;
            }

            public void SetDescription(string description)
            {
                this.description = description;
            }

            public string GetDescription()
            {
                return description;
            }

            public void SetIp(string ipAddress)
            {
                this.ip = ipAddress;
            }

            public string GetIp()
            {
                return ip;
            }

            public void EnterData()
            {
                Console.Write("Set Site Name: ");
                name = Console.ReadLine();

                Console.Write("Set Url: ");
                url = Console.ReadLine();

                Console.Write("Set Description: ");
                description = Console.ReadLine();

                Console.Write("Set IP: ");
                ip = Console.ReadLine();
            }

            public void DisplayData()
            {
                Console.WriteLine("Site Name: " + name);
                Console.WriteLine("URL: " + url);
                Console.WriteLine("Descripyion: " + description);
                Console.WriteLine("IP: " + ip);
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
            private string name;
            private string releaseYear;
            private string description;
            private string phone;
            private string email;

            public void SetName(string name)
            {
                this.name = name;
            }

            public string GetName()
            {
                return name;
            }

            public void SetYear(string year)
            {
                this.releaseYear = year;
            }

            public string GetYear()
            {
                return releaseYear;
            }

            public void SetDescription(string description)
            {
                this.description = description;
            }

            public string GetDescription()
            {
                return description;
            }

            public void SetPhone(string phone)
            {
                this.phone = phone;
            }

            public string GetPhone()
            {
                return phone;
            }

            public void SetEmail(string email)
            {
                this.email = email;
            }

            public string GetEmail()
            {
                return email;
            }

            public void EnterData()
            {
                Console.Write("Set Magazine Name: ");
                name = Console.ReadLine();

                Console.Write("Set Release Year: ");
                releaseYear = Console.ReadLine();

                Console.Write("Set Description: ");
                description = Console.ReadLine();

                Console.Write("Set Phone Number: ");
                phone = Console.ReadLine();

                Console.Write("Set Email: ");
                email = Console.ReadLine();
            }

            public void DisplayData()
            {
                Console.WriteLine("Site Name: " + name);
                Console.WriteLine("Release Year: " + releaseYear);
                Console.WriteLine("Descripyion: " + description);
                Console.WriteLine("Phone: " + phone);
                Console.WriteLine("Email: " + email);
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
            private string name;
            private string adress;
            private string description;
            private string phone;
            private string email;

            public void SetName(string name)
            {
                this.name = name;
            }

            public string GetName()
            {
                return name;
            }

            public void SetAdress(string adress)
            {
                this.adress = adress;
            }

            public string GetAdress()
            {
                return adress;
            }

            public void SetDescription(string description)
            {
                this.description = description;
            }

            public string GetDescription()
            {
                return description;
            }

            public void SetPhone(string phone)
            {
                this.phone = phone;
            }

            public string GetPhone()
            {
                return phone;
            }

            public void SetEmail(string email)
            {
                this.email = email;
            }

            public string GetEmail()
            {
                return email;
            }

            public void EnterData()
            {
                Console.Write("Set Magazine Name: ");
                name = Console.ReadLine();

                Console.Write("Set Adress: ");
                adress = Console.ReadLine();

                Console.Write("Set Description: ");
                description = Console.ReadLine();

                Console.Write("Set Phone Number: ");
                phone = Console.ReadLine();

                Console.Write("Set Email: ");
                email = Console.ReadLine();
            }

            public void DisplayData()
            {
                Console.WriteLine("Site Name: " + name);
                Console.WriteLine("Adress: " + adress);
                Console.WriteLine("Descripyion: " + description);
                Console.WriteLine("Phone: " + phone);
                Console.WriteLine("Email: " + email);
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
