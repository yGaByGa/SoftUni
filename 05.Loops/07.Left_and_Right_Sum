using System;

namespace _07.Left_and_Right_Sum
{
    class LeftAndRightSum
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
                Console.WriteLine("Yes sum {0}", leftsum);
            }
            else
            {
                Console.WriteLine("No , diff {0}", Math.Abs(leftsum - rightsum));
            }
        }
    }
}
