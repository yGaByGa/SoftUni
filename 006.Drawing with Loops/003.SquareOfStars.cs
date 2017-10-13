using System;

namespace _03.SquareOfStars
{
    class SquareOfStars
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int a = 1;

            for (int i = 1; i <= n * n; i++)
            {
                Console.Write(new string('*', 1));
                Console.Write(new string(' ', 1));
                
                if (i == n * a)
                {
                    Console.WriteLine();
                    a++;
                }
            }
        }
    }
}
