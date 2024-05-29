using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw5.NumberGenerators
{
    public class FibonacciNumberGenerator
    {
        private Random _rand = new Random();

        public int Generate()
        {
            int a = 0;
            int b = 1;
            int index = _rand.Next(1, 47);

            for (int i = 2; i <= index; i++)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }

            return b;
        }
    }
}
