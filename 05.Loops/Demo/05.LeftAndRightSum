using System;

namespace _05.Demo5
{
    class Demo5
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftsum = 0;
            int rightsum = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                leftsum += number;
            }

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                rightsum += number;
            }

            if (leftsum == rightsum)
            {
                Console.WriteLine("Yes {0}" , leftsum);
            }
            else
            {
                Console.WriteLine("No , diff is {0}", Math.Abs(leftsum-rightsum));
            }
        }
    }
}
