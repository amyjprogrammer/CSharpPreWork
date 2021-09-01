using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_boolean_challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 101 / 2;
            int value2 = 101 % 2;
            if (value == 50 && value2 == 0)
            {
                Console.WriteLine(true);
            } else
            {
                Console.WriteLine(false);
            }

            //or
            var num1 = ((float)101 / (float)2);
            if (num1 == 50)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            string welcome = "Welcome to the number guesser.";
            string instructions = "The number will be between 1-10.";

            Console.WriteLine(welcome + " " + instructions);
            
            int correctNum = 7;
            int guess = 0;  //set the number to zero so it is wrong the first time

            //will keep running while the player has the wrong number
            while (guess != correctNum)
            {
                Console.Write("Please enter your guess: ");
                string input = Console.ReadLine();

                guess = Convert.ToInt32(input);

                while (guess != correctNum)
                {
                    if (guess > correctNum && guess < 11)
                    {
                        Console.Write("Choose a lower number: ");
                        guess = Convert.ToInt32(Console.ReadLine());
                    } else if (guess < correctNum)
                    {
                        Console.Write("Choose a higher number: ");
                        guess = Convert.ToInt32(Console.ReadLine());
                    } else
                    {
                        Console.Write("The number is 1-10.  Please select again: ");
                        guess = Convert.ToInt32(Console.ReadLine());
                    }
                } 

            }
            Console.WriteLine("Nice Job!  You guessed correctly.");

            Console.WriteLine("Guess");
            int guessNumber = Convert.ToInt16(Console.ReadLine());
            if (guessNumber <= 3)
            {
                Console.WriteLine("Higher:");
            } else if ( guessNumber == 4)
            {
                Console.WriteLine("Winner");
            } else if (guessNumber > 4 && guessNumber < 11)
            {
                Console.WriteLine("Lower");
            } else if (guessNumber > 10)
            {
                Console.WriteLine("Did you read?");
            }
            Console.ReadLine();
        }
    }
}
