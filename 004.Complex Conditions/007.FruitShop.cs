using System;

namespace _07.FruitShop
{
    class FruitShop
    {
        static void Main(string[] args)
        {
                var product = Console.ReadLine().ToLower();
                var day = Console.ReadLine().ToLower();
                var number = double.Parse(Console.ReadLine());

                if ( day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday" )
                {
                    if (product == "banana")
                        Console.WriteLine(number * 2.50);
                    else if (product == "apple")
                        Console.WriteLine(number * 1.20);
                    else if (product == "orange")
                        Console.WriteLine(number * 0.85);
                    else if (product == "grapefruit")
                        Console.WriteLine(number * 1.45);
                    else if (product == "kiwi")
                        Console.WriteLine(number * 2.70);
                    else if (product == "pineapple")
                        Console.WriteLine(number * 5.50);
                    else if (product == "grapes")
                        Console.WriteLine(number * 3.85);
                    else
                    Console.WriteLine("error");
                }
                else if (day == "saturday" || day == "sunday")
                {
                    if (product == "banana")
                        Console.WriteLine(number * 2.70);
                    else if (product == "apple")
                        Console.WriteLine(number * 1.25);
                    else if (product == "orange")
                        Console.WriteLine(number * 0.90);
                    else if (product == "grapefruit")
                        Console.WriteLine(number * 1.60);
                    else if (product == "kiwi")
                        Console.WriteLine(number * 3.00);
                    else if (product == "pineapple")
                        Console.WriteLine(number * 5.60);
                    else if (product == "grapes")
                        Console.WriteLine(number * 4.20);
                    else
                        Console.WriteLine("error");
                }
                else
                    Console.WriteLine("error");
        }
    }
}
