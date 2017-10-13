using System;

namespace _04.FruitOrVegetable
{
    class FruitOrVegetable
    {
        static void Main(string[] args)
        {
            var what = Console.ReadLine().ToLower();

            if (what == "kiwi" || what == "banana" || what == "apple" || what == "cherry" || what == "lemon" || what == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (what == "tomato" || what == "cucumber" || what == "pepper" || what == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
