using System;
using System.Collections.Generic;

namespace övning_list._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> countries = new Dictionary<string, int>
            {
                {"Sverige", 450},
                {"Norge", 385},
                {"Danmark", 43},
                {"Finland", 338}
            };

            Console.WriteLine("Skriv namnet på ett av följande länder: Sverige, Norge, Danmark, Finland");
            string userInput = Console.ReadLine();

            if (countries.ContainsKey(userInput))
            {
                int area = countries[userInput];
                Console.WriteLine($"Storleken på {userInput} är {area} (10^5 km^2).");
            }
            else
            {
                Console.WriteLine("Landet finns inte i listan.");
            }
        }
    }
}
