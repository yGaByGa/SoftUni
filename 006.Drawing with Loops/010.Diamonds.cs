using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("*");
                return;
            }
            if (n == 2)
            {
                Console.WriteLine("**");
                return;
            }

            int dashes;
            int stars;
            int lines;
            int inlineDashes;

            if (n % 2 == 0)
            {
                dashes = n / 2 - 1;
                stars = 2;
                lines = n /2 -1;
                inlineDashes = 2;
            }
            else
            {
                dashes = n / 2;
                stars = 1;
                lines = n / 2;
                inlineDashes = 1;
            }

            string firstLine = String.Format("{0}{1}{0}", new string('-', dashes), new string('*', stars));
            Console.WriteLine(firstLine);

            for (int i = 0; i < lines; i++)
            {
                if (dashes > 0)
                {
                    dashes--;
                }

                Console.Write(new string('-', dashes));
                Console.Write(new string('*', 1));
                Console.Write(new string('-', inlineDashes));
                Console.Write(new string('*', 1));
                Console.WriteLine(new string('-', dashes));

                inlineDashes += 2;
            }

            inlineDashes -= 2;

            for (int i = 0; i < lines -1; i++)
            {
                inlineDashes -= 2;

                Console.Write(new string('-', i +1));
                Console.Write("*");
                Console.Write(new string('-', inlineDashes));
                Console.Write("*");
                Console.Write(new string('-', i + 1));
                Console.WriteLine();
            }

            Console.WriteLine(firstLine);
        }
    }
}
