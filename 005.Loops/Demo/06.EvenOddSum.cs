using System;
namespace _06.Demo6
{
    class demo6
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int evensum = 0;
            int oddsum = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    //even
                    evensum += number;
                }
                else
                {
                    //odd
                    oddsum += number;
                }
            }
            if (evensum == oddsum)
                {
                    Console.WriteLine("Yes Sum= {0}", evensum);
                }
                else
                {
                    Console.WriteLine("No , diff is {0}" , Math.Abs(evensum - oddsum));
                }
        }
    }
}
