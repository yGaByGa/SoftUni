using System;

namespace _04.TriangleOfDollars
{
    class TriangleOfDollars
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (var row = 1; row <= n; row++)
            {
                Console.Write("$");
                for (var col = 1; col < row; col++)
                    Console.Write(" $");
                Console.WriteLine();
            }
        }
    }
}
