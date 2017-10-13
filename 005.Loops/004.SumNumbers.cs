using System;

namespace _04.SumNumbers
{
    class SumNumbers
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
