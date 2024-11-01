using System;

namespace ThrownForALoop
{
    class Program
    {

        static void Main(string[] args)
        {
            string greeting = @"Welcome to thrown for a loop.
            Your one stop shop for used sporting equipment.";
            Console.WriteLine(greeting);
            Console.WriteLine("Please choose an option: ");
            string theMeaningOfLife = "forty-two";
            Console.WriteLine(theMeaningOfLife);
            Console.Write("Please enter a product line: ");
            string response = Console.ReadLine().Trim();
            while (string.IsNullOrEmpty(response))
            {
                Console.WriteLine("You didn't type anything.");
                Console.Write("Try again: ");
                response = Console.ReadLine().Trim();
            }

            Console.WriteLine(@$"You chose: {response}. 
Thank you for your inputs.");



        }
    }
}
