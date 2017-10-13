using System;

namespace Demo3
{
    class demo3
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int total = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                total = total + number;
                // total += number 
            }
            Console.WriteLine(total);
        }
    }
}
