using CitySystem;
using CreditCardSystem;
using EmployeeSystem;
using MatrixSystem;

namespace hw6
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
                case 2: SolveTask2(); break;
                case 3: SolveTask3(); break;
                case 4: SolveTask4(); break;
                default: Console.WriteLine("Unknown task"); break;
            }
        }

        private static void SolveTask1()
        {
            Employee emp1 = new Employee("Alice", 50000);
            Employee emp2 = new Employee("Bob", 60000);

            Console.WriteLine(emp1);
            Console.WriteLine(emp2);

            emp1 += 5000;
            Console.WriteLine(emp1);

            emp2 -= 10000;
            Console.WriteLine(emp2);

            Console.WriteLine($"emp1 == emp2: {emp1 == emp2}");
            Console.WriteLine($"emp1 != emp2: {emp1 != emp2}");
            Console.WriteLine($"emp1 < emp2: {emp1 < emp2}");
            Console.WriteLine($"emp1 > emp2: {emp1 > emp2}");

            Console.WriteLine($"emp1.Equals(emp2): {emp1.Equals(emp2)}");
        }
        private static void SolveTask2()
        {
            Matrix m1 = new Matrix(2, 2);
            m1[0, 0] = 1; m1[0, 1] = 2;
            m1[1, 0] = 3; m1[1, 1] = 4;

            Matrix m2 = new Matrix(2, 2);
            m2[0, 0] = 5; m2[0, 1] = 6;
            m2[1, 0] = 7; m2[1, 1] = 8;

            Matrix m3 = m1 + m2;
            Console.WriteLine("Matrix m3 (m1 + m2):");
            PrintMatrix(m3);

            Matrix m4 = m2 - m1;
            Console.WriteLine("Matrix m4 (m2 - m1):");
            PrintMatrix(m4);

            Console.WriteLine($"m1 == m2: {m1 == m2}");
            Console.WriteLine($"m1 != m2: {m1 != m2}");
            Console.WriteLine($"m1 < m2: {m1 < m2}");
            Console.WriteLine($"m1 > m2: {m1 > m2}");

            Console.WriteLine($"m1.Equals(m2): {m1.Equals(m2)}");
        }

        static void PrintMatrix(Matrix matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        private static void SolveTask3()
        {
            City city1 = new City("City1", 750000);
            City city2 = new City("City2", 860000);

            Console.WriteLine(city1);
            Console.WriteLine(city2);

            city1 += 50000;
            Console.WriteLine(city1);

            city2 -= 100000;
            Console.WriteLine(city2);

            Console.WriteLine($"city1 == city2: {city1 == city2}");
            Console.WriteLine($"city1 != city2: {city1 != city2}");
            Console.WriteLine($"city1 < city2: {city1 < city2}");
            Console.WriteLine($"city1 > city2: {city1 > city2}");

            Console.WriteLine($"city1.Equals(city2): {city1.Equals(city2)}");
        }
        private static void SolveTask4()
        {
            CreditCard cc1 = new CreditCard("Credit Card1", 2000);
            CreditCard cc2 = new CreditCard("Credit Card2", 3000);

            Console.WriteLine(cc1);
            Console.WriteLine(cc2);

            cc1 += 1000;
            Console.WriteLine(cc1);

            cc2 -= 500;
            Console.WriteLine(cc2);

            Console.WriteLine($"cc1 == cc2: {cc1 == cc2}");
            Console.WriteLine($"cc1 != cc2: {cc1 != cc2}");
            Console.WriteLine($"cc1 < cc2: {cc1 < cc2}");
            Console.WriteLine($"cc1 > cc2: {cc1 > cc2}");

            Console.WriteLine($"cc1.Equals(cc2): {cc1.Equals(cc2)}");
        }
    }
}