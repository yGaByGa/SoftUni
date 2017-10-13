using System;

namespace _06.MinNumber
{
    class MinNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int minnumber = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < minnumber)
                {
                    minnumber = number;
                }
            }
            Console.WriteLine(minnumber);
        }
    }
}
