using System;
using System.Collections.Generic;
using System.Net;

namespace ThrownForALoop
{
    class Program
    {

        static void Main(string[] args)
        {
            List<string> products = new List<string>()
            {
                "Football",
                "Hockey Stick",
                "Boomerang",
                "Frisbee",
                "Golf Putter"
            };
            // Console.WriteLine(@"
            // Products: 
            // 1. Football
            // 2. Hockey Stick
            // 3. Boomerang
            // 4. Frisbee
            // 5. Golf Putter");
            Console.WriteLine("Products:");
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {products[i]}");
            }
            Console.Write("Please enter a number from the products above: ");
            String response = Console.ReadLine();
            Console.WriteLine($"You chose {response}");
            int parsedNumber;
            bool isParsedSuccessfully = Int32.TryParse(response, out parsedNumber);
            while (!isParsedSuccessfully || parsedNumber > 5 || parsedNumber < 1)
            {
                Console.Write($"Choose a number between 1 and 5 not {response}: ");
                response = Console.ReadLine();
                isParsedSuccessfully = Int32.TryParse(response, out parsedNumber);
            }
            // switch (parsedNumber)
            // {
            //     case 1:
            //         Console.WriteLine("You chose Football");
            //         break;
            //     case 2:
            //         Console.WriteLine("You chose Hockey Stick");
            //         break;
            //     case 3:
            //         Console.WriteLine("You chose Boomerang");
            //         break;
            //     case 4:
            //         Console.WriteLine("You chose Frisbee");
            //         break;
            //     case 5:
            //         Console.WriteLine("You chose Golf Putter");
            //         break;
            //     default:
            //         Console.WriteLine("You chose something other than what you should have.");
            //         break;
            // }
            Console.WriteLine($"You chose: {products[parsedNumber - 1]}");


        }
    }
}
