using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw5.GuessingGames
{
    public class GuessTheNumber
    {
        private int _min;
        private int _max;

        public GuessTheNumber(int min, int max)
        {
            _min = min;
            _max = max;
        }

        public void Play()
        {
            int guess;
            bool correct = false;
            while (!correct)
            {
                guess = (_min + _max) / 2;
                Console.WriteLine($"Is your number {guess}?");
                Console.WriteLine("Enter 'h' if your number is higher, 'l' if lower, or 'c' if correct");

                switch (Console.ReadLine().ToLower())
                {
                    case "h": _min = guess + 1; break;

                    case "l": _max = guess - 1; break;

                    case "c":
                        Console.WriteLine("The computer guessed your number!");
                        correct = true;
                        break;

                    default: Console.WriteLine("Invalid input"); break;
                }
            }
        }
    }
}
