using System;

namespace _05.MaxNumber
{
    class MaxNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxnumber = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number > maxnumber)
                {
                    maxnumber = number;
                }
            }
            Console.WriteLine(maxnumber);
        }
    }
}
