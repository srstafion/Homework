using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw5.NumberGenerators
{
    public class EvenNumberGenerator
    {
        private Random _rand = new Random();
        public int Generate()
        {
            int number;
            do
            {
                number = _rand.Next();
            } while (number % 2 != 0);
            return number;
        }
    }
}
