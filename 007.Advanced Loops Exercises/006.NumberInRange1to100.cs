using System;

namespace _06.NumberInRange1to100
{
    class NumberInRange1to100
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number in the range [1...100]:");
            int n = int.Parse(Console.ReadLine());
            bool number = true;

            while (number == true)
            {
                
                if (n > 0 && n < 101)
                {
                    Console.WriteLine("The number is: " + n);
                    number = false;
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                    Console.Write("Enter a number in the range [1...100]:");
                    n = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
