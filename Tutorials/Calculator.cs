using System;

namespace Tutorials
{
    class MainClass
    {
         static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter First Number : ");
                Double num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number : ");
                Double num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the operation you want to do (m,d,s,a)");
                String answer = Console.ReadLine();
                switch (answer)
                {
                    case "m":
                        Console.WriteLine($"{num1} multiplied by {num2} = {num1 * num2}");
                        break;
                    case "d":
                        Console.WriteLine($"{num1} dvided by {num2} = {num1 / num2}");
                        break;
                    case "s":
                        Console.WriteLine($"{num1} subtracted by {num2} = {num1 - num2}");
                        break;
                    case "a":
                        Console.WriteLine($"{num1} add to {num2} = {num1 + num2}");
                        break;

                }
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine($"Oops you fell into an error :D {e.Message}");
            }


        }
    }
}
