using System;


namespace _06.Demo
{
    class Demo
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //gornata 4ast na figurata
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i+1; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }

            //dolnata 4ast na figurata
            // i = 1 za da ne printira sredniq red 2 puti
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < n - i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
