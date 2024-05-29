using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw5.NumberGenerators
{
    public class PrimeNumberGenerator
    {
        private Random _rand = new Random();

        public int Generate()
        {
            int number;
            do
            {
                number = _rand.Next();
            } while (!IsPrime(number));
            return number;
        }

        private bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
