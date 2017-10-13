using System;

namespace _02.SmallShop
{
    class SmallShop
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine().ToLower();
            var city = Console.ReadLine().ToLower();
            var number = double.Parse(Console.ReadLine());

            if (city == "sofia")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(0.50 * number);
                }
                else if (product == "water")
                {
                    Console.WriteLine(number * 0.80);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(number * 1.20);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(number * 1.45);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(number * 1.60);
                }
            }
            else if (city == "plovdiv")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(number * 0.40);
                }
                else if (product == "water")
                {
                    Console.WriteLine(number * 0.70);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(number * 1.15);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(number * 1.30);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(number * 1.50);
                }
            }
            else if (city == "varna")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(number * 0.45);
                }
                else if (product == "water")
                {
                    Console.WriteLine(number * 0.70);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(number * 1.10);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(number * 1.35);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(number * 1.55);
                }
            }
        }
    }
}
