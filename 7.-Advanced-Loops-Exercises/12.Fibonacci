using System;

namespace _12.Fibonacci
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int first = 1;
            int second = 1;

            for (int i = 2; i <= n; i++)
            {
                int oldSecond = second;
                second = oldSecond + first;
                first = oldSecond;
            }

            Console.WriteLine(second);
        }
    }
}
