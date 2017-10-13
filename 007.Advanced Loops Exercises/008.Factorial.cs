using System;

namespace _08.Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int fac = 1;
            int i = 1;

            do
            {
                fac *= i;
                i++;
            } while (i <= n);

            Console.WriteLine(fac);
        }
    }
}
