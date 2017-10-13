using System;

namespace _02.ExellenceOrNot
{
    class ExellenceOrNot
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
            else
            {
                Console.WriteLine("not excellent.");
            }
        }
    }
}
