using System;
namespace _14.NumberTable
{
    class NumberTable
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (row + col + 1 > n)
                    {
                        Console.Write(2 * n - (row + col) - 1 + " ");
                    }
                    else
                    {
                        Console.Write(row + col + 1 + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
