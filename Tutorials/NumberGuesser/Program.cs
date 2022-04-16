using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set app vars

            string[] appInfo = { "Number Guesser", "1.0.0", "Mohamed Mansour" };

            // Change text color
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            // Write out app info
            Console.WriteLine($"{appInfo[0]}: Version {appInfo[1]} by {appInfo[2]}");

            // Reset text color
            Console.ResetColor();

            // Ask Users name
            Console.WriteLine("what is your name?");

            // Get user input
            string name = Console.ReadLine();

            Console.WriteLine($"Hello {name}, let's play a game...");

            while (true)
            {

                // Set correct number

                //int correctNumber = 7;        that is fixed let's try random

                // Create a new Random object
                Random random = new Random();

                // assign a number to be randomly choosen from 1 to 10 

                int correctNumber = random.Next(1, 10);

                // init guess var
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                // Do While guess is not correct

                do
                {
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter an actual number");
                        Console.ResetColor();

                        // Keep going
                        continue;
                    }
                    guess = int.Parse(input);
                    if (guess == correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("You Won!");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong Try again");
                        Console.ResetColor();
                    }
                } while (guess != correctNumber);

                // ask player if he/she wants to play again
                Console.WriteLine("wanna play again? [Y or N]");

                // Get an answer

                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                while (answer != "Y" || answer != "N")
                {
                    Console.WriteLine("wanna play again? [Y or N]");
                    answer = Console.ReadLine().ToUpper();
                    if (answer == "Y")
                    {
                        break;

                    }
                    else if (answer == "N")
                    {
                        return;
                    }
                    continue;
                }
            }
        }
    }
}
