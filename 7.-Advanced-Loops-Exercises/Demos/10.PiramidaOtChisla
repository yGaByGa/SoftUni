using System;

namespace _13.NumberPyramid
{
    class NumerPyramid
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = 1;
            int line = 1;

            while (number < (n+1))
            {
                for (int i = 0; i < line; i++)
                {
                    Console.Write(number + " ");
                    number++;
                    if ((n+1) == number)
                    {
                        break;
                    }
                }

                line++;
                Console.WriteLine();
            }
        }
    }
}
