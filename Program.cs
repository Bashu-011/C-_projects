using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomNum = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            string response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                number = randomNum.Next(min, max + 1);

                while (guess != number)
                {
                    Console.WriteLine($"Guess a number between {min} - {max}:");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Guess: {guess}");

                    if (guess > number)
                    {
                        Console.WriteLine($"{guess} is too high");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine($"{guess} is too low");
                    }
                    guesses++;
                }
                Console.WriteLine($"Number: {number}");
                Console.WriteLine("YOU WIN!");
                Console.WriteLine($"Number of guesses: {guesses}");
            }

            Console.ReadKey();
        }
    }
}
