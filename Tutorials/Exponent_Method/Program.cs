using System;

namespace Exponent_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                static int GetPow(int baseNum, int powNum)
                {
                    int result = 1;
                    for (int i = 0; i < powNum; i++)
                    {
                        result = result * baseNum;
                    }
                    return result;
                }
                Console.WriteLine("Enter Base Number: ");
                int baseNum = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Power Number: ");
                int powNum = int.Parse(Console.ReadLine());
                Console.WriteLine($"the result of {baseNum} powered to {powNum} = {GetPow(baseNum, powNum)}");
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine($"Oops you fell into an error :D {e.Message}");
            }
            
        }
    }
}
