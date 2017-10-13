using System;

namespace _11.HalfSumElement
{
    class HalfSumElement
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int maxnumber = 0;
            int total = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                total = total + number;

                if (number > maxnumber)
                {
                    maxnumber = number;
                }
            }
            if (maxnumber == (total - maxnumber))
            {
                Console.WriteLine("Yes sum = " + maxnumber);
            }
            else
            {
                Console.WriteLine("No diff = " + Math.Abs( total - (maxnumber *2)));
            }
        }
    }
}
