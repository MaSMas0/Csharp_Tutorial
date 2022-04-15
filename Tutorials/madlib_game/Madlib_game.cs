using System;

namespace Tutorials
{
    class Program
    {
         static void Main(string[] args)
        {
            string color, pluralNoun, Celebrity;

            Console.WriteLine("Enter a color: ");
            color = Console.ReadLine();

            Console.WriteLine("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.WriteLine("Enter a Celebrity name: ");
            Celebrity = Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"roses are {color}\n{pluralNoun} are blue\nI love {Celebrity}");
        }
    }
}