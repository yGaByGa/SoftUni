// Преобразува Долари в Левове


using System;

namespace USDtoBGN
{
    class USDtoBGN
    {
        static void Main(string[] args)
        {
            Console.Write("Enter USD= ");
            double usd = double.Parse(Console.ReadLine());

            double result = usd * 1.79549;
            Console.WriteLine(Math.Round(result, 2));
        }
    }
}
