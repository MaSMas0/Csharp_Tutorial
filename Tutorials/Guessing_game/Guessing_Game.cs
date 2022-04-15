using System;

namespace Guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "eren";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            do
            {
                if (guessCount < guessLimit)
                {
                    Console.WriteLine("Enter your guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                    Console.WriteLine("You Lost !");

                }

                if (guess == secretWord)
                {
                    Console.WriteLine("You Won !");
                }
                
            } while (guess != secretWord && !outOfGuesses);


        }
    }
}
