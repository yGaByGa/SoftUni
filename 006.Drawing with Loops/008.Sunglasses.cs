using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SunGlasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dashesFigureSize = n - 2;

            Console.Write(new string('*', n * 2));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', n * 2));

            
            for (int i = 0; i < dashesFigureSize; i++)
            {
                bool isMiddle = false;
                Console.Write("*");
                Console.Write(new string('/', n* 2 - 2));
                Console.Write("*");

                if (n % 2 == 0)
                {
                    if (i == dashesFigureSize / 2 - 1)
                    {
                        isMiddle = true;
                        Console.Write(new string('|', n));
                    }
                }
                else
                {
                    if (i == dashesFigureSize / 2)
                    {
                        isMiddle = true;
                        Console.Write(new string('|', n));   
                    }
                }

                if (isMiddle == false)
                {
                    Console.Write(new string(' ', n));
                }
                Console.Write("*");
                Console.Write(new string('/', n * 2 - 2));
                Console.Write("*");
                Console.WriteLine();
            }

            Console.Write(new string('*', n * 2));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', n * 2));
        }
    }
}
